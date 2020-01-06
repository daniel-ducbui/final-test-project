using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Functions.UploadFile;
using ExaminationManagement.Views.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Student
{
    class QuestionPresenter
    {
        IQuestion view;
        int userID;
        BaseQuery baseQuery = new BaseQuery();
        MainFunction mainFunction = new MainFunction();
        UploadFileExcel uploadFile;

        List<TheQuestion> theQuestions = new List<TheQuestion>();

        public string ErrorMessage = null;
        int _permission = -1;

        public QuestionPresenter(IQuestion questionView)
        {
            this.view = questionView;
            this.userID = view.userID;

            Initialize();
        }

        private void Initialize()
        {
            view.LoadQuestion += View_LoadQuestion;
            view.AddQuestion += View_AddQuestion;
            view.EditQuestion += View_EditQuestion;
            view.ShowQuestion += View_ShowQuestion;
            view.ImportQuestion += View_ImportQuestion;

            this._permission = baseQuery.GetUserPermission(this.userID);
            view.permission = this._permission;
        }

        void LoadPermissionQuestion()
        {
            // Student QuestionType = 2
            // I am here. Permission required
            using (var _data = new ExaminationManagementDataContext())
            {
                var questionList = (from q in _data.TheQuestions
                                    where q.QuestionType == this._permission
                                    //&& q.UserID == this.userID
                                    select new { q.QuestionID, q.QuestionContent, q.ChoiceA, q.ChoiceB, q.ChoiceC, q.ChoiceD, q.ChoiceE, q.ChoiceF, q.Answer, q.QuestionLevel, q.Status }).ToList();
                view.DataSource = questionList;
            }
        }

        void ExecuteQuestion(int _questionID)
        {
            string _Content = null, _C1 = null, _C2 = null, _C3 = null, _C4 = null, _C5 = null, _C6 = null, _Answer = null;
            int _Level = 0, _Type = 2, _Status = 0;

            _Content = view.content;
            _C1 = view.choiceA;
            _C2 = view.choiceB;
            _C3 = view.choiceC;
            _C4 = view.choiceD;
            _C5 = view.choiceE;
            _C6 = view.choiceF;
            _Answer = view.answer;

            if (this._permission == 2)
            {
                _Status = 0;
            }
            else
            {
                _Status = 1;
            }

            if (string.IsNullOrEmpty(_Content) || string.IsNullOrEmpty(_C1) || string.IsNullOrEmpty(_C2) || string.IsNullOrEmpty(_C3)
                || string.IsNullOrEmpty(_C4) || string.IsNullOrEmpty(_C5) || string.IsNullOrEmpty(_C6) || string.IsNullOrEmpty(_Answer))
            {
                view.errorMessage = "Please, fill all fields!";
            }
            else
            {
                try
                {
                    baseQuery.ExecuteQuestion(_questionID, _Content, _C1, _C2, _C3, _C4, _C5, _C6, _Answer, _Level, _Type, this.userID, _Status);
                    view.errorMessage = baseQuery.ErrorMessage;
                }
                catch (Exception ex)
                {
                    view.errorMessage = "Something wrong! \nDetails: " + ex.Message;
                }
                LoadPermissionQuestion();
            }
        }

        private void View_LoadQuestion(object sender, EventArgs e)
        {
            LoadPermissionQuestion();
        }

        private void View_AddQuestion(object sender, EventArgs e)
        {
            try
            {
                this.ExecuteQuestion(0);
            }
            catch (Exception ex)
            {
                view.errorMessage = "Something wrong! " + ex.Message;
            }
        }

        private void View_ShowQuestion(object sender, EventArgs e)
        {
            try
            {
                string _tempAnswer = null;
                string[] _tempAnswerArray = null;

                // Get this question
                this.theQuestions = baseQuery.GetQuestion(view.questionID);
                // Get this question's answer string
                _tempAnswer = this.theQuestions.Select(q => q.Answer).FirstOrDefault();
                //Split to array
                _tempAnswerArray = mainFunction.SplitAnswerArray(_tempAnswer);

                // Transfer to view
                view.content = this.theQuestions.Select(q => q.QuestionContent).FirstOrDefault();
                view.choiceA = this.theQuestions.Select(q => q.ChoiceA).FirstOrDefault();
                view.choiceB = this.theQuestions.Select(q => q.ChoiceB).FirstOrDefault();
                view.choiceC = this.theQuestions.Select(q => q.ChoiceC).FirstOrDefault();
                view.choiceD = this.theQuestions.Select(q => q.ChoiceD).FirstOrDefault();
                view.choiceE = this.theQuestions.Select(q => q.ChoiceE).FirstOrDefault();
                view.choiceF = this.theQuestions.Select(q => q.ChoiceF).FirstOrDefault();
                view.previousAnswers = _tempAnswerArray;
            }
            catch (Exception ex)
            {
                view.errorMessage = "Fail to load question!" + ex.Message;
            }
        }

        private void View_EditQuestion(object sender, EventArgs e)
        {
            try
            {
                this.ExecuteQuestion(view.questionID);
            }
            catch (Exception ex)
            {
                view.errorMessage = "Something wrong! " + ex.Message;
            }
        }

        private void View_ImportQuestion(object sender, EventArgs e)
        {
            uploadFile = new UploadFileExcel();
            string fileName = view.fileName;
            uploadFile.ReadQuestionData(fileName, view.userID);

            view.errorMessage = uploadFile.ErrorMessage;
            LoadPermissionQuestion();
        }
    }
}
