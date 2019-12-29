using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Tearcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Presenters.Teacher
{
    public class QuestionManagementPresenter
    {
        IQuestionManagement view;
        List<TheQuestion> theQuestions;
        BindingSource bindingSource;

        public QuestionManagementPresenter(IQuestionManagement questionManagement)
        {
            view = questionManagement;
            Initialize();
        }

        private void Initialize()
        {
            view.LoadTheQuestion += View_LoadTheQustion;
            view.AddQuestion += View_AddQuestion;
            view.SaveChange += View_SaveChange;
            view.DeleteQuestion += View_DeleteQuestion;
            view.InportExcel += View_InportExcel;
            view.BrowserQuestion += View_BrowserQuestion;
            view.questionType.SelectedIndexChanged += QuestionType_SelectedIndexChanged;
        }

        private void QuestionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (view.questionType.SelectedIndex == 1)
            {
                LoadTheQuestionType(2);
                ShowManipulateQuestion(false);


            }
            else
            {
                LoadTheQuestionType(1);
                ShowManipulateQuestion(true);
            }
        }



        private void View_AddQuestion(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                theQuestions = _data.TheQuestions.Where(x => x.QuestionContent == view.questionContent.Text).ToList();
                if(theQuestions.Count() == 0)
                {
                    var theQuestion = new TheQuestion
                    {
                        //Teacher (QuestionType = 1)
                        //Teacher (Status = 1)
                        QuestionLevel = int.Parse(view.questionLevel.Text),
                        QuestionType = 1,
                        QuestionContent = view.questionContent.Text,
                        ChoiceA = view.choiceA.Text,
                        ChoiceB = view.choiceB.Text,
                        ChoiceC = view.choiceC.Text,
                        ChoiceD = view.choiceD.Text,
                        ChoiceE = view.choiceE.Text,
                        ChoiceF = view.choiceF.Text,
                        Answer = view.answer.Text,
                        Status = 1,
                        UserID = view.userID
                    };
                    _data.TheQuestions.InsertOnSubmit(theQuestion);
                    _data.SubmitChanges();

                }
                else
                {
                    MessageBox.Show("This question already exists");
                }
                LoadTheQuestionType(1);
            }            
        }

        private void View_BrowserQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var TheQuestion = _data.TheQuestions.SingleOrDefault(x => x.QuestionID == Convert.ToInt32(view.dgvTheQuestion.CurrentRow.Cells[0].Value.ToString()));
                    if (TheQuestion != null)
                    {
                        TheQuestion.Status = 1;
                    }
                    _data.SubmitChanges();
                    LoadTheQuestionType(2);
                    MessageBox.Show("approved successfully");
                }
            }
            catch 
            {
                MessageBox.Show("Please select a question to browse!");
            }

        }

        private void View_InportExcel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_DeleteQuestion(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var TheQuestion = _data.TheQuestions.SingleOrDefault(x => x.QuestionID == Convert.ToInt32(view.dgvTheQuestion.CurrentRow.Cells[0].Value.ToString()));
                if (TheQuestion != null)
                {
                    try
                    {
                        _data.TheQuestions.DeleteOnSubmit(TheQuestion);
                        _data.SubmitChanges();
                        MessageBox.Show("Delete success");
                    }
                    catch
                    {
                        MessageBox.Show("Cannot be deleted because the question belongs to the exam");
                    }

                    LoadTheQuestionType(1);
                }
            }
        }

        private void View_SaveChange(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var TheQuestions = _data.TheQuestions.SingleOrDefault(x => x.QuestionID == Convert.ToInt32(view.dgvTheQuestion.CurrentRow.Cells[0].Value.ToString()));
                if (TheQuestions != null)
                {
                    TheQuestions.QuestionLevel = int.Parse(view.questionLevel.Text);
                    TheQuestions.QuestionContent = view.questionContent.Text;
                    TheQuestions.ChoiceA = view.choiceA.Text;
                    TheQuestions.ChoiceB = view.choiceB.Text;
                    TheQuestions.ChoiceC = view.choiceC.Text;
                    TheQuestions.ChoiceD = view.choiceD.Text;
                    TheQuestions.ChoiceE = view.choiceE.Text;
                    TheQuestions.ChoiceF = view.choiceF.Text;
                    TheQuestions.Answer = view.answer.Text;
                }
                _data.SubmitChanges();
                LoadTheQuestionType(1);
            }
        }

        private void View_LoadTheQustion(object sender, EventArgs e)
        {
            view.questionType.SelectedIndex = 0;
        }

        private void ShowManipulateQuestion(Boolean x)
        {
            view.addQuestion.Enabled = x;
            view.saveChange.Enabled = x;
            view.deleteQuestion.Enabled = x;
            view.inportExcel.Enabled = x;
            view.browserQuestion.Enabled = !x;
        }
        private void LoadTheQuestionType(int whose)
        {
            bindingSource = new BindingSource();
            using (var examinationManagement = new ExaminationManagementDataContext())
            {
                examinationManagement.DeferredLoadingEnabled = false;
                theQuestions = examinationManagement.TheQuestions.Where(x => x.QuestionType == whose).ToList();
                bindingSource.DataSource = theQuestions;
                view.dgvTheQuestion.DataSource = bindingSource;

                view.questionLevel.DataBindings.Clear();                
                view.questionContent.DataBindings.Clear();
                view.choiceA.DataBindings.Clear();
                view.choiceB.DataBindings.Clear();
                view.choiceC.DataBindings.Clear();
                view.choiceD.DataBindings.Clear();
                view.choiceE.DataBindings.Clear();
                view.choiceF.DataBindings.Clear();
                view.answer.DataBindings.Clear();

                view.questionLevel.DataBindings.Add("Text", bindingSource, "QuestionLevel");
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
    }
}
