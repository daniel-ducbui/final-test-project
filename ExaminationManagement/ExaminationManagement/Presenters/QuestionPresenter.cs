using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Presenters
{
    public class QuestionPresenter
    {
        List<TheQuestion> questions;
        IQuestionView view;
        public object DataGridViewItems { get; set; }
        BindingSource bindingSource;

        public QuestionPresenter(IQuestionView iq)
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
                var question = examination.TheQuestions.SingleOrDefault(q => q.questionID == int.Parse(view.questionID.Text));
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
                var question = examination.TheQuestions.SingleOrDefault(q => q.questionID == int.Parse(view.questionID.Text));
                if(question!=null)
                {
                    question.level = view.level.Text;
                    question.content = view.content.Text;
                    question.choiceA = view.choiceA.Text;
                    question.choiceB = view.choiceB.Text;
                    question.choiceC = view.choiceC.Text;
                    question.choiceD = view.choiceD.Text;
                    question.choiceE = view.choiceE.Text;
                    question.choiceF = view.choiceF.Text;
                    question.answer = view.correctAnswer.Text;
                }
                examination.SubmitChanges();
                Load();
            }
        }

        private void View_NewQuestion(object sender, EventArgs e)
        {
            var question = new TheQuestion
            {
                questionID = int.Parse(view.questionID.Text),
                level = view.level.Text,
                content = view.content.Text,
                choiceA = view.choiceA.Text,
                choiceB = view.choiceB.Text,
                choiceC = view.choiceC.Text,
                choiceD = view.choiceD.Text,
                choiceE=view.choiceE.Text,
                choiceF=view.choiceF.Text,
                answer=view.correctAnswer.Text,
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
                view.questionID.DataBindings.Clear();
                view.level.DataBindings.Clear();
                view.content.DataBindings.Clear();
                view.choiceA.DataBindings.Clear();
                view.choiceB.DataBindings.Clear();
                view.choiceC.DataBindings.Clear();
                view.choiceD.DataBindings.Clear();
                view.choiceE.DataBindings.Clear();
                view.choiceF.DataBindings.Clear();
                view.correctAnswer.DataBindings.Clear();

                view.questionID.DataBindings.Add("Text", bindingSource, "questionID");
                view.level.DataBindings.Add("Text", bindingSource, "level");
                view.content.DataBindings.Add("Text", bindingSource, "content");
                view.choiceA.DataBindings.Add("Text", bindingSource, "choiceA");
                view.choiceB.DataBindings.Add("Text", bindingSource, "choiceB");
                view.choiceC.DataBindings.Add("Text", bindingSource, "choiceC");
                view.choiceD.DataBindings.Add("Text", bindingSource, "choiceD");
                view.choiceE.DataBindings.Add("Text", bindingSource, "choiceE");
                view.choiceF.DataBindings.Add("Text", bindingSource, "choiceF");
                view.correctAnswer.DataBindings.Add("Text", bindingSource, "answer");


            }
        }
       
    }

   
}
