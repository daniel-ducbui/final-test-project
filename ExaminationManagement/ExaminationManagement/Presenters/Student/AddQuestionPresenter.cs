using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Student
{
    public class AddQuestionPresenter
    {
        IAddQuestion view;

        public AddQuestionPresenter(IAddQuestion addQuestionView)
        {
            view = addQuestionView;
            Initialize();
        }

        private void Initialize()
        {
            view.SaveQuestion += View_SaveQuestion;
        }

        private void View_SaveQuestion(object sender, EventArgs e)
        {
            var theQuestion = new TheQuestion
            {
                //Student (QuestionType = 2)
                //Teacher (QuestionType = 1)
                //Student (QuestionLevel = 0)

                QuestionLevel = 0,
                QuestionType = 2,
                QuestionContent = view.questionContent,
                ChoiceA = view.choiceA,
                ChoiceB = view.choiceB,
                ChoiceC = view.choiceC,
                ChoiceD = view.choiceD,
                ChoiceE = view.choiceE,
                ChoiceF = view.choiceF,
                Answer = view.answer,
                UserID = view.userID
            };
            using (var _data = new ExaminationManagementDataContext())
            {
                _data.TheQuestions.InsertOnSubmit(theQuestion);
                _data.SubmitChanges();
                view.questionContent = null;
                view.choiceA = null;
                view.choiceB = null;
                view.choiceC = null;
                view.choiceD = null;
                view.choiceE = null;
                view.choiceF = null;
                view.answer = null;
            }
        }
    }
}
