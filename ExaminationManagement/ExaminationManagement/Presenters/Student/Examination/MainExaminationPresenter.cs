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
        List<string> userCurrentAnswers = new List<string>();
        List<string> _tempAnswersList;

        int resultID = 0;
        int flag = 0;
        int flag2 = 0;
        int numberOfQuestion = 0;

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

            this.numberOfQuestion = baseQuery.GetNumbersOfQuestion(view.testID);
            this.resultID = baseQuery.FindResult(view.userID, view.testID);

            view.numberOfQuestion = this.numberOfQuestion;
            // 1nd Way
            //userAnswersList.Add(null);

            // 2nd Way
            this.userCurrentAnswers.Add(null);
            this.userAnswersList = baseQuery.GetUserAnsweredList(this.resultID);
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

            // 2nd Way
            this.userAnswersList = baseQuery.GetUserAnsweredList(this.resultID);

            if (userAnswersList.Count > 0 && this.flag == 0)
            {
                view.previousAnswers = userAnswersList[currentIndex];
                this.flag = 1;
            }
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

                // 1nd Way
                /* 
                 * 
                 * IMPORTANT == DO NOT DELETE == IMPORTANT
                 * 
                 */
                // Add this answer to answered list

                //int listIndex = currentIndex;

                //userAnswersList.RemoveAt(listIndex);
                //userAnswersList.Insert(listIndex, userAnswers);

                //if (userAnswersList.Count == ++listIndex)
                //{
                //    userAnswersList.Add(null);
                //}

                if (this.flag2 == 0)
                {
                    int listIndex = currentIndex;

                    userCurrentAnswers.RemoveAt(listIndex);
                    userCurrentAnswers.Insert(listIndex, answer);

                    if (userCurrentAnswers.Count == ++listIndex)
                    {
                        userCurrentAnswers.Add(null);
                    }
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
                //int previousScore = baseQuery.Score(this.resultID, questionID);
                //int totalScore = baseQuery.GetTotalScore(this.resultID);

                baseQuery.SaveResultDetails(questionID, this.resultID, (answer == null ? "-" : answer), currentScore);

                // Problem here
                //if (currentScore == 1 && previousScore == 0)
                //{
                //    baseQuery.SaveResult(this.resultID, view.userID, view.testID, totalScore + 1);
                //}
                //else if (currentScore == 0 && previousScore == 1 && totalScore > 0)
                //{
                //    baseQuery.SaveResult(this.resultID, view.userID, view.testID, totalScore - 1);
                //}
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

                if (this.resultID == 0)
                {
                    this.resultID = baseQuery.FindResult(view.userID, view.testID);
                }

                if (userAnswersList.Count < 1)
                {
                    foreach (var item in testQuestionList)
                    {
                        baseQuery.SaveResultDetails(item.QuestionID, this.resultID, "-", 0);
                    }
                }

                // EnrollExamination maybe here

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

                // Both Ways
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

                // Both Ways
                view.previousAnswers = userAnswersList[currentIndex];

                LoadQuestion();
            }
        }

        private void View_Submit(object sender, EventArgs e)
        {
            try
            {
                CheckResult(testQuestionList[currentIndex].QuestionID, view.answer);

                // Save all the answers
                this.userCurrentAnswers.RemoveAt(this.numberOfQuestion);
                _tempAnswersList = new List<string>();
                _tempAnswersList = this.userCurrentAnswers;
                int listIndex = 0;
                this.currentIndex = 0;

                this.flag2 = 1;

                foreach (var item in _tempAnswersList)
                {
                    CheckResult(testQuestionList[this.currentIndex].QuestionID, item);
                    this.currentIndex++;
                }

                // Calculate TotalScore 
                int _totalScore = baseQuery.TotalScore(this.resultID);

                // Save total score
                baseQuery.SaveResult(this.resultID, view.userID, view.testID, _totalScore);
                // EnrollExamination
                baseQuery.EnrollExamination(view.userID, view.examineeListID);

                this.ErrorMessage = baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }
    }
}
