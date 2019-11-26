using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Presenters
{
    public class TheQuestionPresenter
    {
        List<TheQuestion> questions;
        ITheQuestion view;
        public object DataGridViewItems { get; set; }
        BindingSource bindingSource;

        public TheQuestionPresenter(ITheQuestion iq)
        {
            view = iq;
            Initializer();

        }

        private void Initializer()
        {
            Load();
            view.NewQuestion += View_NewQuestion;
            view.UpdateQuestion += View_UpdateQuestion;
            view.DeleteQuestion += View_DeleteQuestion;
        }

        private void View_DeleteQuestion(object sender, EventArgs e)
        {
            using (var examination = new ExaminationManagementDataContext())
            {
                var question = examination.TheQuestions.SingleOrDefault(q => q.QuestionID == int.Parse(view.QuestionID.Text));
                if (question != null)
                {
                    examination.TheQuestions.DeleteOnSubmit(question);
                    examination.SubmitChanges();
                    Load();
                }
            }
        }

        private void View_UpdateQuestion(object sender, EventArgs e)
        {
            using (var examination = new ExaminationManagementDataContext())
            {
                var question = examination.TheQuestions.SingleOrDefault(q => q.QuestionID == int.Parse(view.QuestionID.Text));
                if (question != null)
                {
                    question.QuestionLevel = int.Parse(view.QuestionLevel.Text);
                    question.QuestionContent = view.QuestionContent.Text;
                    question.ChoiceA = view.ChoiceA.Text;
                    question.ChoiceB = view.ChoiceB.Text;
                    question.ChoiceC = view.ChoiceC.Text;
                    question.ChoiceD = view.ChoiceD.Text;
                    question.ChoiceE = view.ChoiceE.Text;
                    question.ChoiceF = view.ChoiceF.Text;
                    question.Answer = view.Answer.Text;
                }
                examination.SubmitChanges();
                Load();
            }
        }

        private void View_NewQuestion(object sender, EventArgs e)
        {
            var question = new TheQuestion
            {
                QuestionID = int.Parse(view.QuestionID.Text),
                QuestionLevel = int.Parse(view.QuestionLevel.Text),
                QuestionContent = view.QuestionContent.Text,
                ChoiceA = view.ChoiceA.Text,
                ChoiceB = view.ChoiceB.Text,
                ChoiceC = view.ChoiceC.Text,
                ChoiceD = view.ChoiceD.Text,
                ChoiceE = view.ChoiceE.Text,
                ChoiceF = view.ChoiceF.Text,
                Answer = view.Answer.Text,
            };

            using (var examination = new ExaminationManagementDataContext())
            {
                examination.TheQuestions.InsertOnSubmit(question);
                examination.SubmitChanges();
                Load();
            }

        }

        public void Load()
        {
            using (var examination = new ExaminationManagementDataContext())
            {
                bindingSource = new BindingSource();


                questions = examination.TheQuestions.ToList();
                bindingSource.DataSource = questions;

                DataGridViewItems = bindingSource;

                view.DataGridViewItems = DataGridViewItems;
                view.QuestionID.DataBindings.Clear();
                view.QuestionLevel.DataBindings.Clear();
                view.QuestionContent.DataBindings.Clear();
                view.ChoiceA.DataBindings.Clear();
                view.ChoiceB.DataBindings.Clear();
                view.ChoiceC.DataBindings.Clear();
                view.ChoiceD.DataBindings.Clear();
                view.ChoiceE.DataBindings.Clear();
                view.ChoiceF.DataBindings.Clear();
                view.Answer.DataBindings.Clear();

                view.QuestionID.DataBindings.Add("Text", bindingSource, "QuestionID");
                view.QuestionLevel.DataBindings.Add("Text", bindingSource, "QuestionLevel");
                view.QuestionContent.DataBindings.Add("Text", bindingSource, "QuestionContent");
                view.ChoiceA.DataBindings.Add("Text", bindingSource, "ChoiceA");
                view.ChoiceB.DataBindings.Add("Text", bindingSource, "ChoiceB");
                view.ChoiceC.DataBindings.Add("Text", bindingSource, "ChoiceC");
                view.ChoiceD.DataBindings.Add("Text", bindingSource, "ChoiceD");
                view.ChoiceE.DataBindings.Add("Text", bindingSource, "ChoiceE");
                view.ChoiceF.DataBindings.Add("Text", bindingSource, "ChoiceF");
                view.Answer.DataBindings.Add("Text", bindingSource, "Answer");


            }
        }


    }
}
