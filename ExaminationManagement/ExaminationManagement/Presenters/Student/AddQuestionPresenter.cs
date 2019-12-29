using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Student;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Presenters.Student
{
    public class AddQuestionPresenter
    {
        IAddQuestion view;
        List<TheQuestion> theQuestions;
        BindingSource bindingSource;

        public AddQuestionPresenter(IAddQuestion addQuestionView)
        {
            view = addQuestionView;
            Initialize();
        }

        private void Initialize()
        {
            view.SaveQuestion += View_SaveQuestion;
            view.LoadTheQuestion += View_LoadTheQuestion;
            view.UpdateQuestion += View_UpdateQuestion;
        }

        private void View_UpdateQuestion(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                foreach (var item in theQuestions)
                {
                    if(theQuestions.Where(x => x.UserID == view.userID).Count() > 1)
                    {
                        continue;
                    }
                    var theQusetion = _data.TheQuestions.SingleOrDefault(x => x.UserID == view.userID);
                    if (theQusetion != null)
                    {
                        theQusetion.QuestionContent = view.questionContent.Text;
                        theQusetion.ChoiceA = view.choiceA.Text;
                        theQusetion.ChoiceB = view.choiceB.Text;
                        theQusetion.ChoiceC = view.choiceC.Text;
                        theQusetion.ChoiceD = view.choiceD.Text;
                        theQusetion.ChoiceE = view.choiceE.Text;
                        theQusetion.ChoiceF = view.choiceF.Text;
                        theQusetion.Answer = view.answer.Text;
                    }
                }
                _data.SubmitChanges();
            }
        }

        private void View_LoadTheQuestion(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            using (var _data = new ExaminationManagementDataContext())
            {
                theQuestions = _data.TheQuestions.Where(x => x.UserID == view.userID).ToList();
                bindingSource.DataSource = theQuestions;
                view.dgvTheQuestion.DataSource = bindingSource;

                view.questionContent.DataBindings.Clear();
                view.choiceA.DataBindings.Clear();
                view.choiceB.DataBindings.Clear();
                view.choiceC.DataBindings.Clear();
                view.choiceD.DataBindings.Clear();
                view.choiceE.DataBindings.Clear();
                view.choiceF.DataBindings.Clear();
                view.answer.DataBindings.Clear();

                view.questionContent.DataBindings.Add("Text", bindingSource, "QuestionContent");
                view.choiceA.DataBindings.Add("Text", bindingSource, "ChoiceA");
                view.choiceB.DataBindings.Add("Text", bindingSource, "ChoiceB");
                view.choiceC.DataBindings.Add("Text", bindingSource, "ChoiceC");
                view.choiceD.DataBindings.Add("Text", bindingSource, "ChoiceD");
                view.choiceE.DataBindings.Add("Text", bindingSource, "ChoiceE");
                view.choiceF.DataBindings.Add("Text", bindingSource, "ChoiceF");
                view.answer.DataBindings.Add("Text", bindingSource, "Answer");
            }
        }
        private void View_SaveQuestion(object sender, EventArgs e)
        {
            try
            {
                var theQuestion = new TheQuestion
                {

                    //Student (QuestionType = 2)
                    //Teacher (QuestionType = 1)
                    //Student (QuestionLevel = 0)
                    //Student (Status = 0)

                    QuestionLevel = 0,
                    QuestionType = 2,
                    QuestionContent = view.questionContent.Text,
                    ChoiceA = view.choiceA.Text,
                    ChoiceB = view.choiceB.Text,
                    ChoiceC = view.choiceC.Text,
                    ChoiceD = view.choiceD.Text,
                    ChoiceE = view.choiceE.Text,
                    ChoiceF = view.choiceF.Text,
                    Answer = view.answer.Text,
                    Status = 0,
                    UserID = view.userID
                };
                using (var _data = new ExaminationManagementDataContext())
                {
                    _data.TheQuestions.InsertOnSubmit(theQuestion);
                    _data.SubmitChanges();
                }
                View_LoadTheQuestion(sender, e);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Fail! \n" + ex);
            }

        }
    }
}