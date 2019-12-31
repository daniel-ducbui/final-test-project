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
    public class ManageTheListOfContestantsPresenter
    {
        IManageTheListOfContestants view;
        BindingSource bsExamineeList;
        BindingSource bsExamineeDetails;
        BindingSource bsStudent;
        public ManageTheListOfContestantsPresenter(IManageTheListOfContestants manageTheListOfContestants)
        {
            view = manageTheListOfContestants;
            Initialize();
        }

        private void Initialize()
        {
            view.txt_listingCode.TextChanged += Txt_listingCode_TextChanged;
            view.LoadAllStudent += View_LoadAllStudent;
            view.LoadAllExamineeList += View_LoadAllExamineeList;
            view.LoadStudentOfExamineeList += View_LoadStudentOfExamineeList;
            view.CreateList += View_CreateList;
            view.AddStudent += View_AddStudent;
            view.DeleteStudent += View_DeleteStudent;
            view.Update += View_Update;
            view.DeleteTheTest += View_DeleteTheTest;
        }

        private void View_DeleteTheTest(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {

                    var countExamineeList = _data.TheExaminations.Where(t => t.ExamineeListID == int.Parse(view.dgv_listOfContestants.CurrentRow.Cells[0].Value.ToString())).ToList();
                    if (countExamineeList.Count() == 0)
                    {
                        var examineeListDetails = _data.ExamineeListDetails.Where(t => t.ExamineeListID == int.Parse(view.dgv_listOfContestants.CurrentRow.Cells[0].Value.ToString())).ToList();
                        foreach (var item in examineeListDetails)
                        {
                            _data.ExamineeListDetails.DeleteOnSubmit(item);
                            _data.SubmitChanges();
                        }
                        var examineeList = _data.ExamineeLists.SingleOrDefault(t => t.ExamineeListID == int.Parse(view.dgv_listOfContestants.CurrentRow.Cells[0].Value.ToString()));
                        _data.ExamineeLists.DeleteOnSubmit(examineeList);
                        _data.SubmitChanges();
                        MessageBox.Show("Delete successful");
                        LoadAllExamineeList();
                        LoadStudentOfExamineeList();
                    }
                    else
                    {
                        MessageBox.Show("Lists used for exams cannot be deleted");
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
                    var examineeList = examination.ExamineeLists.SingleOrDefault(t => t.ExamineeListID == int.Parse(view.dgv_listOfContestants.CurrentRow.Cells[0].Value.ToString()));
                    if (examineeList != null)
                    {
                        examineeList.ExamineeListName = view.txt_listName.Text;
                    }
                    examination.SubmitChanges();
                    MessageBox.Show("Update successful");
                    LoadAllExamineeList();
                }
            }
            catch
            {
                MessageBox.Show("Ten phai duoi 10 ki tu");
            }
        }

        private void View_DeleteStudent(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var student = _data.ExamineeListDetails.SingleOrDefault(t => t.ExamineeListID == int.Parse(view.dgv_partListCandidates.CurrentRow.Cells[0].Value.ToString())
                                    && t.UserID == int.Parse(view.dgv_partListCandidates.CurrentRow.Cells[1].Value.ToString()));
                    _data.ExamineeListDetails.DeleteOnSubmit(student);
                    _data.SubmitChanges();
                    MessageBox.Show("Delete successful");
                    LoadStudentOfExamineeList();
                }
            }
            catch
            {
                MessageBox.Show("You have not selected a candidate to delete");
            }
        }

        private void View_AddStudent(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var student = _data.ExamineeListDetails.Where(t => t.ExamineeListID == int.Parse(view.txt_listingCode.Text)
                                    && t.UserID == int.Parse(view.dgv_allOfStudents.CurrentRow.Cells[0].Value.ToString())).ToList();

                    if (student.Count() == 0)
                    {
                        var examineeListDetail = new ExamineeListDetail
                        {
                            ExamineeListID = int.Parse(view.txt_listingCode.Text),
                            UserID = int.Parse(view.dgv_allOfStudents.CurrentRow.Cells[0].Value.ToString()),
                        };

                        _data.ExamineeListDetails.InsertOnSubmit(examineeListDetail);
                        _data.SubmitChanges();
                        LoadStudentOfExamineeList();
                    }

                    if (student.Count() > 0)
                    {
                        MessageBox.Show("Candidates already on the list");
                    }
                }
            }
            catch
            {
                MessageBox.Show("No list created yet");
            }
        }

        private void View_CreateList(object sender, EventArgs e)
        {
            try
            {
                if (view.txt_listName.Text.Length > 0)
                {
                    using (var examination = new ExaminationManagementDataContext())
                    {
                        var examineeList = new ExamineeList
                        {
                            ExamineeListName = view.txt_listName.Text,
                        };
                        examination.ExamineeLists.InsertOnSubmit(examineeList);
                        examination.SubmitChanges();
                    }
                    MessageBox.Show("Create success..!");
                    LoadStudentOfExamineeList();
                    LoadAllExamineeList();
                }
                else
                {
                    MessageBox.Show("Please enter enough information");
                    view.txt_listingCode.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Ten danh sach da ton tai");
            }
        }

        private void View_LoadStudentOfExamineeList(object sender, EventArgs e)
        {
            LoadStudentOfExamineeList();               
        }

        private void LoadStudentOfExamineeList()
        {
            if (view.txt_listingCode.Text.Length > 0)
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var listExaminee = _data.ExamineeListDetails.Where(e => e.ExamineeListID == int.Parse(view.txt_listingCode.Text))
                        .Select(e => new { e.ExamineeListID, e.UserID }).ToList();

                    bsExamineeDetails = new BindingSource();
                    bsExamineeDetails.DataSource = listExaminee;
                    view.dgv_partListCandidates.DataSource = bsExamineeDetails;
                }
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
                var listExaminee = _data.ExamineeLists.Select(e => new { e.ExamineeListID, e.ExamineeListName }).ToList();
                bsExamineeList = new BindingSource();
                bsExamineeList.DataSource = listExaminee;
                view.dgv_listOfContestants.DataSource = bsExamineeList;

                view.txt_listingCode.DataBindings.Clear();
                view.txt_listName.DataBindings.Clear();

                view.txt_listingCode.DataBindings.Add("Text", bsExamineeList, "ExamineeListID");
                view.txt_listName.DataBindings.Add("Text", bsExamineeList, "ExamineeListName");
            }
        }

        private void View_LoadAllStudent(object sender, EventArgs e)
        {
            LoadAllStudent();
        }

        private void Txt_listingCode_TextChanged(object sender, EventArgs e)
        {
            LoadStudentOfExamineeList();
        }

        private void LoadAllStudent()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var students = (from ac in _data.Accounts
                                join acd in _data.AccountDetails on ac.UserID equals acd.UserID
                                where ac.Permission == 1
                                select new
                                {
                                    ac.UserID,
                                    name = acd.Name,
                                    classID = acd.ClassID,
                                    gradeID = acd.GradeID,
                                }).ToList();
                bsStudent = new BindingSource();
                bsStudent.DataSource = students;
                view.dgv_allOfStudents.DataSource = bsStudent;
            }
        }
    }
}
