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
    public class TestListPresenter
    {
        ITestList view;
        BindingSource bsTest;
        BindingSource bsTestListDetail;
        BindingSource bsTestList;
        public TestListPresenter(ITestList testList)
        {
            view = testList;
            Initialize();
        }

        private void Initialize()
        {
            view.LoadAllTestList += View_LoadAllTestList;
            view.LoadAllTheTest += View_LoadAllTheTest;
            view.LoadTheTestOfTestList += View_LoadTheTestOfTestList;
            view.CreateTheTest += View_CreateTheTest;
            view.AddTheTest += View_AddTheTest;
            view.DeleteTheTest += View_DeleteTheTest;
            view.Update += View_Update;
            view.Delete += View_Delete;
            view.txt_testID.TextChanged += Txt_testID_TextChanged;
        }

        private void View_Delete(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {

                    var countTestList = _data.TheExaminations.Where(t => t.TestListID == view.dgv_listOfAllExamQuestions.CurrentRow.Cells[0].Value.ToString()).ToList();
                    if (countTestList.Count() == 0)
                    {
                        var tests = _data.TestListDetails.Where(t => t.TestID == view.dgv_listOfAllExamQuestions.CurrentRow.Cells[0].Value.ToString()).ToList();
                        foreach (var item in tests)
                        {
                            _data.TestListDetails.DeleteOnSubmit(item);
                            _data.SubmitChanges();
                        }
                        var testList = _data.TestLists.SingleOrDefault(t => t.TestListID == view.dgv_listOfAllExamQuestions.CurrentRow.Cells[0].Value.ToString());
                        _data.TestLists.DeleteOnSubmit(testList);
                        _data.SubmitChanges();
                        MessageBox.Show("Delete successful");
                        LoadAllTestList();
                        LoadTheTestOfTestList();
                    }
                    else
                    {
                        MessageBox.Show("The title has been used and cannot be deleted");
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
                using (var _data = new ExaminationManagementDataContext())
                {
                    var testList = _data.TestLists.SingleOrDefault(t => t.TestListID == view.dgv_listOfAllExamQuestions.CurrentRow.Cells[0].Value.ToString());
                    if (testList != null)
                    {
                        testList.TestListName = view.txt_testName.Text;

                    }
                    _data.SubmitChanges();
                    LoadAllTestList();
                }
            }
            catch
            {
            }
        }

        private void View_DeleteTheTest(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var test = _data.TestListDetails.SingleOrDefault(t => t.TestListID == view.dgv_partOfTheExam.CurrentRow.Cells[0].Value.ToString()
                                    && t.TestID == view.dgv_partOfTheExam.CurrentRow.Cells[1].Value.ToString());
                    _data.TestListDetails.DeleteOnSubmit(test);
                    _data.SubmitChanges();
                    LoadTheTestOfTestList();
                }
            }
            catch
            {
                MessageBox.Show("Ban chua chon de thi de xoa");
            }
        }

        private void Txt_testID_TextChanged(object sender, EventArgs e)
        {
            LoadTheTestOfTestList();
        }

        private void View_CreateTheTest(object sender, EventArgs e)
        {
            try
            {
                if (view.txt_testID.Text.Length > 0 && view.txt_testName.Text.Length > 0)
                {
                    using (var examination = new ExaminationManagementDataContext())
                    {
                        var testList = new TestList
                        {
                            TestListID = view.txt_testID.Text,
                            TestListName = view.txt_testName.Text,
                        };
                        examination.TestLists.InsertOnSubmit(testList);
                        examination.SubmitChanges();
                    }
                    MessageBox.Show("Create success ..!");
                    LoadTheTestOfTestList();
                    LoadAllTestList();
                }
                else
                {
                    MessageBox.Show("Please enter enough information");
                    view.txt_testID.Focus();
                }
            }
            catch
            {
                MessageBox.Show("A set of test questions exists ...");
            }
        }

        private void View_AddTheTest(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var theTest = _data.TestListDetails.Where(t => t.TestListID == view.txt_testID.Text
                                       && t.TestID == view.dgv_allTheTest.CurrentRow.Cells[0].Value.ToString()).ToList();

                    if (theTest.Count() == 0)
                    {
                        var testListDetail = new TestListDetail
                        {
                            TestListID = view.txt_testID.Text,
                            TestID = view.dgv_allTheTest.CurrentRow.Cells[0].Value.ToString(),
                        };

                        _data.TestListDetails.InsertOnSubmit(testListDetail);
                        _data.SubmitChanges();
                        LoadTheTestOfTestList();
                    }

                    if (theTest.Count() > 0)
                    {
                        MessageBox.Show("This test is already in the series");
                    }
                }
            }
            catch
            {
                MessageBox.Show("No set of threads yet ");
            }
        }

        private void View_LoadTheTestOfTestList(object sender, EventArgs e)
        {
            LoadTheTestOfTestList();
        }

        private void LoadTheTestOfTestList()
        {
            if (view.txt_testID.Text.Length > 0)
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    bsTestListDetail = new BindingSource();
                    var testList = _data.TestListDetails.Where(t => t.TestListID == view.txt_testID.Text).Select(t => new { t.TestListID, t.TestID }).ToList();
                    bsTestListDetail.DataSource = testList;
                    view.dgv_partOfTheExam.DataSource = bsTestListDetail;
                }
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
                bsTest = new BindingSource();
                var listTheTest = _data.TheTests.Select(x => new { x.TestID, x.TestName }).ToList();
                bsTest.DataSource = listTheTest;
                view.dgv_allTheTest.DataSource = bsTest;
            }
        }

        private void View_LoadAllTestList(object sender, EventArgs e)
        {
            LoadAllTestList();
        }

        private void LoadAllTestList()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                bsTestList = new BindingSource();
                var testList = _data.TestLists.Select(t => new { t.TestListID, t.TestListName }).ToList();

                bsTestList.DataSource = testList;
                view.dgv_listOfAllExamQuestions.DataSource = bsTestList;

                view.txt_testID.DataBindings.Clear();
                view.txt_testName.DataBindings.Clear();

                view.txt_testID.DataBindings.Add("Text", bsTestList, "TestListID");
                view.txt_testName.DataBindings.Add("Text", bsTestList, "TestListName");
            }
        }
    }
}
