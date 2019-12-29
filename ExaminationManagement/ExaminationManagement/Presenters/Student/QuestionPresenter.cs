using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
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
        BaseQuery baseQuery;
        public string ErrorMessage = null;

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
        }

        void LoadData()
        {
            // Student QuestionType = 2

            using (var _data = new ExaminationManagementDataContext())
            {
                var questionList = (from q in _data.TheQuestions
                                    where q.QuestionType == 2
                                    where q.UserID == this.userID
                                    select new { q.QuestionContent, q.ChoiceA, q.ChoiceB, q.ChoiceC, q.ChoiceD, q.ChoiceE, q.ChoiceF, q.Answer, q.Status }).ToList();
                view.DataSource = questionList;
            }
        }

        private void View_LoadQuestion(object sender, EventArgs e)
        {
            LoadData();
        }

        private void View_AddQuestion(object sender, EventArgs e)
        {
            string _Content = null, _C1 = null, _C2 = null, _C3 = null, _C4 = null, _C5 = null, _C6 = null, _Answer = null;
            int _Level = 0, _Type = 2;

            _Content = view.content;
            _C1 = view.choiceA;
            _C2 = view.choiceB;
            _C3 = view.choiceC;
            _C4 = view.choiceD;
            _C5 = view.choiceE;
            _C6 = view.choiceF;
            _Answer = view.answer;

            try
            {
                baseQuery = new BaseQuery();
                baseQuery.ExecuteQuestion(0, _Content, _C1, _C2, _C3, _C4, _C5, _C6, _Answer, _Level, _Type, this.userID);
                this.ErrorMessage = baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = "Something wrong! \nDetails: " + ex.Message;
            }
            LoadData();
        }
    }
}
