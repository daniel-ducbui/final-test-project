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
        //List<TheQuestion> theQuestions;

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
                QuestionLevel = int.Parse(view.questionLevel),
                QuestionType = 1,
                QuestionContent = view.questionContent,
                ChoiceA = view.choiceA,
                ChoiceB = view.choiceB,
                ChoiceC = view.choiceC,
                ChoiceD = view.choiceD,
                ChoiceE = view.choiceE,
                ChoiceF = view.choiceF,
                Answer = view.answer,
                //UserID = int.Parse(temp)
                UserID = 0
            };
            using (var _data = new ExaminationManagementDataContext())
            {
                _data.TheQuestions.InsertOnSubmit(theQuestion);
                _data.SubmitChanges();
            }
        }
    }
}
