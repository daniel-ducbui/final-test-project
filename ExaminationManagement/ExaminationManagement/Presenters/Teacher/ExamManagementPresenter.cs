using ExaminationManagement.Forms.Teacher;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Tearcher;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Presenters.Teacher
{
    public class ExamManagementPresenter
    {
        IExamManagement view;
        BindingSource bsTestList;
        BindingSource bsExamineeList;
        BindingSource bsExamination;

        ManageTheListOfContestantsControlPanel manageTheListOfContestantsControlPanel;
        TestListControlPanel testListControlPanel;
        public ExamManagementPresenter(IExamManagement examManagement)
        {
            view = examManagement;
            Initialize();
        }

        private void Initialize()
        {
            view.ccb_chooseGrade.SelectedIndex = 0;
            view.ccb_kindOfExam.SelectedIndex = 0;
            view.ComboboxOnlySelect += View_ComboboxOnlySelect;
            view.LoadAllExamination += View_LoadAllExamination;
            view.LoadAllExamineeList += View_LoadAllExamineeList;
            view.LoadAllTestList += View_LoadAllTestList;
            view.CreateExam += View_CreateExam;
            view.Update += View_Update;
            view.Delete += View_Delete;
            view.CreateExamList += View_CreateExamList;
            view.CreateTheExamSet += View_CreateTheExamSet;
        }

        private void View_CreateTheExamSet(object sender, EventArgs e)
        {
            testListControlPanel = new TestListControlPanel(view.userID);
            testListControlPanel.ShowDialog();
        }

        private void View_CreateExamList(object sender, EventArgs e)
        {
            manageTheListOfContestantsControlPanel = new ManageTheListOfContestantsControlPanel( view.userID);
            manageTheListOfContestantsControlPanel.ShowDialog();
        }

        private void View_Delete(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var exam = _data.TheExaminations.SingleOrDefault(t => t.ExaminationID == int.Parse(view.dgv_allExams.CurrentRow.Cells[0].Value.ToString()));
                    _data.TheExaminations.DeleteOnSubmit(exam);
                    _data.SubmitChanges();
                    LoadAllExamination();
                    MessageBox.Show("Delete successful...");
                }
            }
            catch
            {
                MessageBox.Show("Exam has taken place. Cannot be deleted");
            }
        }

        private void View_Update(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var exam = _data.TheExaminations.SingleOrDefault(t => t.ExaminationID == int.Parse(view.dgv_allExams.CurrentRow.Cells[0].Value.ToString()));

                    DateTime startDate, endDate;
                    DateTime.TryParseExact(view.mtb_startDay.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate);
                    DateTime.TryParseExact(view.mtb_endDay.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate);

                    if (exam != null)
                    {
                        exam.ExaminationName = view.txt_examName.Text;
                        exam.ExaminationType = int.Parse(view.ccb_kindOfExam.Text);
                        exam.ExamineeListID = int.Parse(view.ccb_selectTheExamList.Text);
                        exam.TestListID = view.ccb_chooseTheTestSet.Text;
                        exam.GradeID = int.Parse(view.ccb_chooseGrade.Text);
                        exam.StartDate = startDate;
                        exam.EndDate = endDate;
                        exam.Time = int.Parse(view.txt_time.Text);
                    }
                    _data.SubmitChanges();
                    LoadAllExamination();
                    MessageBox.Show("Update successful...");
                }
            }
            catch
            {
                MessageBox.Show("Fail update...");
            }
        }

        private void View_CreateExam(object sender, EventArgs e)
        {
            try
            {
                if (view.txt_examName.Text.Length > 0 && view.ccb_kindOfExam.Text.Length > 0 && view.ccb_chooseTheTestSet.Text.Length > 0
                    && view.ccb_selectTheExamList.Text.Length > 0 && view.mtb_endDay.Text.Length > 0 && view.txt_time.Text.Length > 0)
                {
                    using (var examination = new ExaminationManagementDataContext())
                    {
                        DateTime startDate, endDate;
                        DateTime.TryParseExact(view.mtb_startDay.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate);
                        DateTime.TryParseExact(view.mtb_endDay.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate);

                        var exam = new TheExamination
                        {
                            ExaminationName = view.txt_examName.Text,
                            ExaminationType = int.Parse(view.ccb_kindOfExam.Text),
                            TestListID = view.ccb_chooseTheTestSet.Text,
                            ExamineeListID = int.Parse(view.ccb_selectTheExamList.Text),
                            CreateDate = DateTime.Now,
                            StartDate = startDate,
                            EndDate = endDate,
                            Time = int.Parse(view.txt_time.Text),
                            Creator = view.userID.ToString(),
                            GradeID = int.Parse(view.ccb_chooseGrade.Text),
                        };
                        examination.TheExaminations.InsertOnSubmit(exam);
                        examination.SubmitChanges();
                    }
                    MessageBox.Show("Create success..!");
                    LoadAllExamination();
                }
                else
                {
                    MessageBox.Show("Please enter enough information");
                    view.txt_examName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please enter again..");
            }
        }

        private void View_LoadAllTestList(object sender, EventArgs e)
        {
            LoadAllTestList();
        }

        private void LoadAllTestList()
        {
            try
            {
                using (var examination = new ExaminationManagementDataContext())
                {
                    bsTestList = new BindingSource();
                    var testList = examination.TestLists.Select(t => t.TestListID).ToList();

                    bsTestList.DataSource = testList;
                    view.ccb_chooseTheTestSet.DataSource = bsTestList;
                }
            }
            catch
            {
            }
        }

        private void View_LoadAllExamineeList(object sender, EventArgs e)
        {
            LoadAllExamineeList();                
        }

        private void LoadAllExamineeList()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var listExaminee = _data.ExamineeLists.Select(e => e.ExamineeListID).ToList();

                bsExamineeList = new BindingSource();
                bsExamineeList.DataSource = listExaminee;
                view.ccb_selectTheExamList.DataSource = bsExamineeList;
            }
        }

        private void View_LoadAllExamination(object sender, EventArgs e)
        {
            LoadAllExamination();
        }

        private void LoadAllExamination()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var theExaminations = _data.TheExaminations.Select(e => new
                {
                    e.ExaminationID,
                    e.ExaminationName,
                    e.ExaminationType,
                    e.ExamineeListID,
                    e.TestListID,
                    e.GradeID,
                    e.StartDate,
                    e.EndDate,
                    e.Time,
                }).ToList();

                bsExamination = new BindingSource();
                bsExamination.DataSource = theExaminations;
                view.dgv_allExams.DataSource = bsExamination;

                view.txt_examName.DataBindings.Clear();
                view.ccb_kindOfExam.DataBindings.Clear();
                view.ccb_chooseTheTestSet.DataBindings.Clear();
                view.ccb_selectTheExamList.DataBindings.Clear();
                view.ccb_chooseGrade.DataBindings.Clear();
                view.mtb_startDay.DataBindings.Clear();
                view.mtb_endDay.DataBindings.Clear();
                view.txt_time.DataBindings.Clear();

                view.txt_examName.DataBindings.Add("Text", bsExamination, "ExaminationName");
                view.ccb_kindOfExam.DataBindings.Add("Text", bsExamination, "ExaminationType");
                view.ccb_chooseTheTestSet.DataBindings.Add("Text", bsExamination, "TestListID");
                view.ccb_selectTheExamList.DataBindings.Add("Text", bsExamination, "ExamineeListID");
                view.ccb_chooseGrade.DataBindings.Add("Text", bsExamination, "GradeID");
                view.mtb_startDay.DataBindings.Add("Text", bsExamination, "StartDate");
                view.mtb_endDay.DataBindings.Add("Text", bsExamination, "EndDate");
                view.txt_time.DataBindings.Add("Text", bsExamination, "Time");
            }
        }

        private void View_ComboboxOnlySelect(object sender, EventArgs e)
        {
            ComboboxOnlySelect();
        }

        private void ComboboxOnlySelect()
        {
            view.ccb_chooseGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            view.ccb_chooseTheTestSet.DropDownStyle = ComboBoxStyle.DropDownList;
            view.ccb_kindOfExam.DropDownStyle = ComboBoxStyle.DropDownList;
            view.ccb_selectTheExamList.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
