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
    public class ExamManagementPresenter
    {
        IExamManagement view;
        BindingSource bsQuestion;
        BindingSource bsTestDetails;
        BindingSource bsTheTest;
        public ExamManagementPresenter(IExamManagement examManagement)
        {
            view = examManagement;
            Initialize();
        }

        private void Initialize()
        {
            view.LoadAllQuestion += View_LoadAllQuestion;
            view.LoadAllTheTest += View_LoadAllTheTest;
            view.LoadQuestionOfTheTest += View_LoadQuestionOfTheTest;
            view.txt_examPaperCode.TextChanged += Txt_examPaperCode_TextChanged;
            view.CreateTest += View_CreateTest;
            view.Update += View_Update;
            view.DeleteTheTest += View_DeleteTheTest;
            view.AddTheQuestion += View_AddTheQuestion;
            view.DeleteTheQuestion += View_DeleteTheQuestion;
        }

        private void Txt_examPaperCode_TextChanged(object sender, EventArgs e)
        {
            LoadQuestionOfTheTest();
        }

        private void View_DeleteTheQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var question = _data.TestDetails.SingleOrDefault(t => t.TestID == view.dgv_examInformation.CurrentRow.Cells[0].Value.ToString()
                                    && t.QuestionID == int.Parse(view.dgv_examInformation.CurrentRow.Cells[1].Value.ToString()));
                    _data.TestDetails.DeleteOnSubmit(question);
                    _data.SubmitChanges();
                    LoadQuestionOfTheTest();
                }
            }
            catch
            {
                MessageBox.Show("You have not selected the question to delete");
            }
        }

        private void View_AddTheQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var question = _data.TestDetails.Where(t => t.TestID == view.txt_examPaperCode.Text
                                       && t.QuestionID == int.Parse(view.dgv_questionSection.CurrentRow.Cells[0].Value.ToString())).ToList();

                    if (question.Count() == 0)
                    {
                        var testDetail = new TestDetail
                        {
                            TestID = view.txt_examPaperCode.Text,
                            QuestionID = int.Parse(view.dgv_questionSection.CurrentRow.Cells[0].Value.ToString()),
                        };

                        _data.TestDetails.InsertOnSubmit(testDetail);
                        _data.SubmitChanges();
                        LoadQuestionOfTheTest();
                    }

                    if (question.Count() > 0)
                    {
                        MessageBox.Show("The question has this sentence");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Not created the exam");
            }
        }

        private void View_DeleteTheTest(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {

                    var countTheTest = _data.TestLists.Where(t => t.TestListID == view.dgv_listOfAllTheQuestion.CurrentRow.Cells[0].Value.ToString()).ToList();
                    if (countTheTest.Count() == 0)
                    {
                        var testDetails = _data.TestDetails.Where(t => t.TestID == view.dgv_listOfAllTheQuestion.CurrentRow.Cells[0].Value.ToString()).ToList();
                        foreach (var item in testDetails)
                        {
                            _data.TestDetails.DeleteOnSubmit(item);
                            _data.SubmitChanges();
                        }
                        var theTest = _data.TheTests.SingleOrDefault(t => t.TestID == view.dgv_listOfAllTheQuestion.CurrentRow.Cells[0].Value.ToString());
                        _data.TheTests.DeleteOnSubmit(theTest);
                        _data.SubmitChanges();
                        MessageBox.Show("Delete successful");
                        LoadAllTheTest();
                        LoadQuestionOfTheTest();
                    }
                    else
                    {
                        MessageBox.Show("The test is used so it cannot be deleted");
                    }
                }
            }
            catch
            {
            }
        }

        private void View_Update(object sender, EventArgs e)
        {
            try
            {
                using (var examination = new ExaminationManagementDataContext())
                {
                    var testList = examination.TheTests.SingleOrDefault(t => t.TestID == view.dgv_listOfAllTheQuestion.CurrentRow.Cells[0].Value.ToString());
                    if (testList != null)
                    {
                        testList.TestName = view.txt_examName.Text;
                    }
                    examination.SubmitChanges();
                    MessageBox.Show("Update success!");
                    LoadAllTheTest();
                }
            }
            catch
            {
            }
        }

        private void View_CreateTest(object sender, EventArgs e)
        {
            try
            {
                if (view.txt_examPaperCode.Text.Trim().Length > 0 && view.txt_examName.Text.Trim().Length > 0)
                {
                    using (var _data = new ExaminationManagementDataContext())
                    {
                        var theTest = new TheTest
                        {
                            TestID = view.txt_examPaperCode.Text,
                            TestName = view.txt_examName.Text,
                        };
                        _data.TheTests.InsertOnSubmit(theTest);
                        _data.SubmitChanges();
                    }
                    MessageBox.Show("Create success!");
                    LoadQuestionOfTheTest();
                    LoadAllTheTest();
                }
                else
                {
                    MessageBox.Show("Please enter full information!!!");
                    view.txt_examPaperCode.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Existing exam questions..");
            }
        }

        private void View_LoadQuestionOfTheTest(object sender, EventArgs e)
        {
            LoadQuestionOfTheTest();

        }
        private void LoadQuestionOfTheTest()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                bsTestDetails = new BindingSource();
                var testDetails = _data.TestDetails.Where(t => t.TestID == view.txt_examPaperCode.Text).Select(t => new { t.TestID, t.QuestionID }).ToList();
                bsTestDetails.DataSource = testDetails;
                view.dgv_examInformation.DataSource = bsTestDetails;
            }
        }

        private void View_LoadAllTheTest(object sender, EventArgs e)
        {
            LoadAllTheTest();
        }

        private void LoadAllTheTest()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                bsTheTest = new BindingSource();
                var theTests = _data.TheTests.Select(t => new { t.TestID, t.TestName });
                bsTheTest.DataSource = theTests;
                view.dgv_listOfAllTheQuestion.DataSource = bsTheTest;

                view.txt_examPaperCode.DataBindings.Clear();
                view.txt_examName.DataBindings.Clear();

                view.txt_examPaperCode.DataBindings.Add("Text", bsTheTest, "TestID");
                view.txt_examName.DataBindings.Add("Text", bsTheTest, "TestName");
            }
        }

        private void View_LoadAllQuestion(object sender, EventArgs e)
        {
            LoadAllQuestion();
        }

        private void LoadAllQuestion()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                bsQuestion = new BindingSource();
                var questions = _data.TheQuestions.Where(q => q.Status == 1).Select(q => new { q.QuestionID, q.QuestionContent }).ToList();
                bsQuestion.DataSource = questions;
                view.dgv_questionSection.DataSource = bsQuestion;
            }
        }
    }
}
