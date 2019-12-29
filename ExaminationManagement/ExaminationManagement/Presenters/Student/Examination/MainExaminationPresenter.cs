using ExaminationManagement.Views.Student.Examination;
using ExaminationManagement.Functions.ConnectDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationManagement.Functions;

namespace ExaminationManagement.Presenters.Student.Examination
{
    class MainExaminationPresenter
    {
        int currentIndex = 0;

        IMainExamination view;
        BaseQuery baseQuery = new BaseQuery();

        List<TheQuestion> testQuestionList;
        List<string[]> userAnswersList = new List<string[]>();

        int resultID = 0;

        public string ErrorMessage = null;

        public MainExaminationPresenter(IMainExamination mainExaminationView)
        {
            this.view = mainExaminationView;

            Initialize();
        }

        private void Initialize()
        {
            view.NextQuestion += View_NextQuestion;
            view.PreviousQuestion += View_PreviousQuestion;
            view.LoadQuestion += View_LoadQuestion;
            view.Submit += View_Submit;
            view.SelectedChangedQuestion += View_SelectedChangedQuestion;

            using (var _data = new ExaminationManagementDataContext())
            {
                testQuestionList = new List<TheQuestion>();

                testQuestionList = (from q in _data.TheQuestions
                                    join td in _data.TestDetails
                                        on q.QuestionID equals td.QuestionID
                                    where td.QuestionID == q.QuestionID
                                    select q).ToList();
            }

            this.resultID = baseQuery.FindResult(view.userID, view.testID);
            userAnswersList.Add(null);
        }

        void LoadQuestion()
        {
            var question = testQuestionList[currentIndex];

            view.content = question.QuestionContent;
            view.choiceA = question.ChoiceA;
            view.choiceB = question.ChoiceB;
            view.choiceC = question.ChoiceC;
            view.choiceD = question.ChoiceD;
            view.choiceE = question.ChoiceE;
            view.choiceF = question.ChoiceF;

            view.currentIndex = currentIndex;

            //userAnswersList = baseQuery.GetUserAnsweredList(this.resultID);

            //if (userAnswersList.Count > 0)
            //{
            //    view.previousAnswers = userAnswersList[currentIndex];
            //}
        }

        private void View_SelectedChangedQuestion(object sender, Functions.Events.SelectedChangedEventArgs e)
        {
            if (e.Index > -1)
            {
                currentIndex = e.Index;
                LoadQuestion();
            }
        }

        int Score(int questionID, string answer)
        {
            int score = 0;

            string[] trueAnswers = null, userAnswers = null;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _question = (from q in _data.TheQuestions
                                 where q.QuestionID == questionID
                                 select q).FirstOrDefault();

                string _trueAnswer = (_question.Answer).ToLower();

                MainFunction mainFunction = new MainFunction();

                trueAnswers = mainFunction.SplitAnswerArray(_trueAnswer);
                userAnswers = mainFunction.SplitAnswerArray(answer);

                /* 
                 * 
                 * IMPORTANT == DO NOT DELETE == IMPORTANT
                 * 
                 */

                // Add this answer to answered list

                int listIndex = currentIndex;

                userAnswersList.RemoveAt(listIndex);
                userAnswersList.Insert(listIndex, userAnswers);

                if (userAnswersList.Count == ++listIndex)
                {
                    userAnswersList.Add(null);
                }

                if (userAnswers.Length == trueAnswers.Length)
                {
                    foreach (var item in userAnswers)
                    {
                        if (!trueAnswers.Contains(item))
                        {
                            score = 0;
                            break;
                        }
                        score = 1;
                    }
                }
            }

            return score;
        }

        void CheckResult(int questionID, string answer)
        {
            try
            {
                int currentScore = Score(questionID, answer);
                int previousScore = baseQuery.Score(this.resultID, questionID);

                baseQuery.SaveResultDetails(questionID, this.resultID, (answer == null ? "-" : answer), currentScore);

                int totalScore = baseQuery.TotalScore(this.resultID);

                if (currentScore == 1 && previousScore == 0)
                {
                    baseQuery.SaveResult(this.resultID, view.userID, view.testID, totalScore + 1);
                }
                else if (currentScore == 0 && previousScore == 1 && totalScore > 0)
                {
                    baseQuery.SaveResult(this.resultID, view.userID, view.testID, totalScore - 1);
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = "Fail!" + ex.Message;
            }
        }

        private void View_LoadQuestion(object sender, EventArgs e)
        {
            try
            {
                baseQuery.SaveResult(this.resultID, view.userID, view.testID, 0);

                foreach (var item in testQuestionList)
                {
                    baseQuery.SaveResultDetails(item.QuestionID, this.resultID, "-", 0);
                }

                baseQuery.EnrollExamination(view.userID, view.examineeListID);

                LoadQuestion();
            }
            catch (Exception ex)
            {
                this.ErrorMessage = "Fail!" + ex.Message;
            }
        }

        private void View_NextQuestion(object sender, EventArgs e)
        {
            CheckResult(testQuestionList[currentIndex].QuestionID, view.answer);

            if (currentIndex < testQuestionList.Count - 1)
            {
                currentIndex++;

                view.previousAnswers = userAnswersList[currentIndex];

                LoadQuestion();
            }
        }

        private void View_PreviousQuestion(object sender, EventArgs e)
        {
            CheckResult(testQuestionList[currentIndex].QuestionID, view.answer);

            if (currentIndex > 0)
            {
                currentIndex--;

                view.previousAnswers = userAnswersList[currentIndex];

                LoadQuestion();
            }
        }

        private void View_Submit(object sender, EventArgs e)
        {
            try
            {
                CheckResult(testQuestionList[currentIndex].QuestionID, view.answer);
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }
    }
}
