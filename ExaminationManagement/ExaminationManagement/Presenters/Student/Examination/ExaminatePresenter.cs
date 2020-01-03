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
    class ExaminatePresenter
    {
        int currentIndex = 0;

        IExaminate view;
        BaseQuery baseQuery = new BaseQuery();

        List<TheQuestion> testQuestionList;
        List<string[]> userAnsweredList = new List<string[]>(); // On table ResultDetails (Splitted)
        List<string[]> trueAnswersList = new List<string[]>();  // On table TheQuestion (Splitted)
        //List<string> userCurrentAnswers = new List<string>();   // While do the test (Non-split)

        int numberOfQuestion = 0;
        int examinationType = 0;
        int examineeListID = 0;
        string testListID = null;

        int resultID = 0;
        int times = 0;
        bool isSubmitted = false;

        int flagFirstLoadQuestion = 0;
        //int flagOnSubmit = 0;
        int flagSubmitted = 0;
        string flagNullAnswer = null;

        public string ErrorMessage = null;

        public ExaminatePresenter(IExaminate mainExaminationView)
        {
            this.view = mainExaminationView;

            Initialize();
        }

        private void Initialize()
        {
            view.NextQuestion += View_NextQuestion;
            view.PreviousQuestion += View_PreviousQuestion;
            view.LoadQuestion += View_LoadQuestion;
            view.ShowThisAnswer += View_ShowThisAnswer;
            view.ShowAllAnswers += View_ShowAllAnswers;
            view.Submit += View_Submit;
            view.SelectedChangedQuestion += View_SelectedChangedQuestion;

            // Get the examination's information
            using (var _data = new ExaminationManagementDataContext())
            {
                testQuestionList = new List<TheQuestion>();

                testQuestionList = (from q in _data.TheQuestions
                                    join td in _data.TestDetails
                                        on q.QuestionID equals td.QuestionID

                                    where td.TestID == view.testID
                                     && td.QuestionID == q.QuestionID

                                    select q).ToList();

                var _examinationInfomation = (from ex in _data.TheExaminations
                                              where ex.ExaminationID == view.examinationID
                                              select ex).FirstOrDefault();

                var _username = (from a in _data.AccountDetails
                                 where a.UserID == view.userID
                                 select a.Name).FirstOrDefault();

                view.username = _username;

                this.examinationType = _examinationInfomation.ExaminationType;
                this.examineeListID = Convert.ToInt32(_examinationInfomation.ExamineeListID);
                this.testListID = _examinationInfomation.TestListID;

                view.time = _examinationInfomation.Time;
            }

            // Get number of questions
            this.numberOfQuestion = baseQuery.GetNumberOfQuestion(view.testID);

            if (this.numberOfQuestion < 1)
            {
                this.ErrorMessage = "No question found!";
            }

            // Transfer to view
            view.numberOfQuestion = this.numberOfQuestion;
            view.examinationType = this.examinationType;
            view.flagShowAllAnswers = 0;

            // Find if result has already existed - if not equals 0 (occur when turned off by accident)
            this.resultID = baseQuery.FindResult(view.userID, view.testID, this.testListID, view.examinationID);

            // Initialize user's current answers
            //int _tempNumberOfQuestion = this.numberOfQuestion;

            //while (_tempNumberOfQuestion > 0)
            //{
            //    this.userCurrentAnswers.Add(null);
            //    _tempNumberOfQuestion--;
            //}

            this.isSubmitted = baseQuery.IsSubmitted(this.resultID);

            // Check if user have already enrolled and not submit
            if (this.resultID != 0)
            {
                if (!this.isSubmitted) // and isSubmitted == false
                {
                    view.flagSubmitted = 1; // Enrolled
                }
                else // and isSubmitted == true
                {
                    // this.flagSubmitted = 0 -- force create new result
                    this.flagSubmitted = 0;
                }
                this.times = baseQuery.FindTimes(this.resultID);
            }
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

            // Get user existed answers list (occur when turned off by accident) - if not filled by (-)
            this.userAnsweredList = baseQuery.GetUserAnsweredList(this.resultID);

            if (userAnsweredList.Count > 0 && this.flagFirstLoadQuestion == 0)
            {
                view.previousAnswers = userAnsweredList[currentIndex];
                this.flagFirstLoadQuestion = 1;
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

        private void View_LoadQuestion(object sender, EventArgs e)
        {
            try
            {
                // If first enroll
                if (this.resultID == 0)
                {
                    // Initialize Result
                    baseQuery.SaveResult(this.resultID, view.userID, view.testID, 0, 1, 0, this.examineeListID);

                    this.resultID = baseQuery.FindResult(view.userID, view.testID, this.testListID, view.examinationID);
                    this.times = baseQuery.FindTimes(this.resultID);

                    this.InitializeResultDetails();
                    this.flagSubmitted = 0;
                }
                else
                {
                    // Get sign if user want to continue or start again
                    this.flagSubmitted = view.flagSubmitted;
                    // Get user's answered answers list
                    if (this.flagSubmitted == 1) // User want to get old answers
                    {
                        this.userAnsweredList = baseQuery.GetUserAnsweredList(this.resultID);
                        this.times = baseQuery.FindTimes(this.resultID);
                    }
                    else // User want to start again/user has submitted in the last time
                    {
                        int _times = this.times;
                        // Initialize Result
                        baseQuery.SaveResult(0, view.userID, view.testID, 0, ++_times, 0, view.examinationID);

                        this.resultID = baseQuery.FindResult(view.userID, view.testID, this.testListID, this.examineeListID);
                        this.times = baseQuery.FindTimes(this.resultID);

                        this.InitializeResultDetails();
                        this.flagSubmitted = 0;
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

        void InitializeResultDetails()
        {
            foreach (var item in testQuestionList)
            {
                baseQuery.SaveResultDetails(item.QuestionID, this.resultID, "-", 0);
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

                // Add this answer to current answered list

                //if (this.flagOnSubmit == 0)
                //{
                //    int listIndex = currentIndex;

                //    userCurrentAnswers.RemoveAt(listIndex);
                //    userCurrentAnswers.Insert(listIndex, answer);

                //    //if (userCurrentAnswers.Count == ++listIndex)
                //    //{
                //    //    userCurrentAnswers.Add(null);
                //    //}
                //}

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

                baseQuery.SaveResultDetails(questionID, this.resultID, (answer == null ? "-" : answer), currentScore);
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

                view.previousAnswers = userAnsweredList[currentIndex];

                LoadQuestion();
            }
        }

        private void View_PreviousQuestion(object sender, EventArgs e)
        {
            CheckResult(testQuestionList[currentIndex].QuestionID, view.answer);

            if (currentIndex > 0)
            {
                currentIndex--;

                view.previousAnswers = userAnsweredList[currentIndex];

                LoadQuestion();
            }
        }

        private void View_ShowThisAnswer(object sender, EventArgs e)
        {
            int _questionID = testQuestionList[currentIndex].QuestionID;

            trueAnswersList = baseQuery.GetTrueAnswersList(view.testID, _questionID);

            view.previousAnswers = trueAnswersList[0];
        }

        private void View_ShowAllAnswers(object sender, EventArgs e)
        {
            if (view.flagShowAllAnswers == 0)
            {
                view.flagShowAllAnswers = 1;
            }
            else
            {
                view.flagShowAllAnswers = 0;
            }
        }

        void CheckNullAnswer()
        {
            string[] choices = { "a", "b", "c", "d", "e", "f" };
            this.flagNullAnswer = null;

            // Check answer that user answered
            // For second enroll or else
            foreach (var item in this.userAnsweredList)
            {
                if (!choices.Any(item.Contains))
                {
                    this.flagNullAnswer += "a"; // Have null answer
                    break;
                }
            }

            // Check answer
            // For all
            //if (this.flagSubmitted != 1 && this.times == 1)
            //{
            //    foreach (var item in this.userCurrentAnswers)
            //    {
            //        if (!choices.Any(item.Contains))
            //        {
            //            this.flagNullAnswer += "b";
            //            break;
            //        }
            //    }
            //}

            //if (this.flagNullAnswer == "b")
            //{
            //    // Concatenate each answer in database to userCurrentList
            //    // then call CheckResult()
            //    int _index = 0;

            //    foreach (var item in this.userAnsweredList)
            //    {
            //        string _temp = string.Join(" ", item);

            //        this.userCurrentAnswers.RemoveAt(_index);
            //        this.userCurrentAnswers.Insert(_index, _temp);
            //    }

            //    if (this.flagNullAnswer == "ab")
            //    {
            //        this.flagNullAnswer = "a";
            //    }
            //    else
            //    {
            //        this.flagNullAnswer = null;
            //    }
            //}
        }

        private void View_Submit(object sender, EventArgs e)
        {
            try
            {
                CheckResult(testQuestionList[currentIndex].QuestionID, view.answer);

                // Check if answer is null (normal submit)
                if (view.flagForceSubmit == 1)
                {
                    this.userAnsweredList = baseQuery.GetUserAnsweredList(this.resultID);
                    this.CheckNullAnswer();
                }

                // If time is up or user want to submit anyway
                if (view.flagForceSubmit == 2)
                {
                    this.flagNullAnswer = null;
                }

                // Have one or more question that have not answer yet
                if (this.flagNullAnswer == "a")
                {
                    view.flagForceSubmit = 3;
                }
                else
                {
                    //_tempAnswersList = new List<string>();
                    //_tempAnswersList = this.userCurrentAnswers;

                    //this.currentIndex = 0;
                    //this.flagOnSubmit = 1;

                    // Save all answer
                    //foreach (var item in _tempAnswersList)
                    //{
                    //    CheckResult(testQuestionList[this.currentIndex].QuestionID, item);
                    //    this.currentIndex++;
                    //}

                    // Calculate total score 
                    int _totalScore = baseQuery.TotalScore(this.resultID);

                    // Force Submit = 1 => Normal submit
                    // Force Submit = 2 => Time Up/User want to submit anyway

                    // Save total score
                    baseQuery.SaveResult(this.resultID, view.userID, view.testID, _totalScore, this.times, view.flagForceSubmit, view.examinationID);

                    if (this.examinationType == 1)
                    {
                        // Enroll the examination
                        baseQuery.EnrollExamination(view.userID, this.examineeListID, 2);
                    }

                    this.ErrorMessage = baseQuery.ErrorMessage;
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }
    }
}
