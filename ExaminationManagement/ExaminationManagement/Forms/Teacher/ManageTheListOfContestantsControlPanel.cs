using ExaminationManagement.Presenters.Teacher;
using ExaminationManagement.Views.Tearcher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Teacher
{
    public partial class ManageTheListOfContestantsControlPanel : Form, IManageTheListOfContestants
    {
        ManageTheListOfContestantsPresenter manageTheListOfContestantsPresenter;
        int userID;
        public ManageTheListOfContestantsControlPanel(int userID)
        {
            InitializeComponent();
            manageTheListOfContestantsPresenter = new ManageTheListOfContestantsPresenter(this);
            this.userID = userID;
            btn_back.Click += Btn_back_Click;
            Load += ManageTheListOfContestantsControlPanel_Load;
            btn_addStudent.Click += Btn_addStudent_Click;
            btn_deleteStudent.Click += Btn_deleteStudent_Click;
            btn_createList.Click += Btn_createList_Click;
            btn_update.Click += Btn_update_Click;
            btn_deleteTheTest.Click += Btn_deleteTheTest_Click;
        }

        private void Btn_deleteTheTest_Click(object sender, EventArgs e)
        {
            DeleteTheTest?.Invoke(this, null);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Update?.Invoke(this, null);
        }

        private void Btn_deleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent?.Invoke(this, null);
        }

        private void Btn_createList_Click(object sender, EventArgs e)
        {
            CreateList?.Invoke(this, null);
        }

        private void Btn_addStudent_Click(object sender, EventArgs e)
        {
            AddStudent?.Invoke(this, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageTheListOfContestantsControlPanel_Load(object sender, EventArgs e)
        {
            LoadAllExamineeList?.Invoke(this, null);
            LoadStudentOfExamineeList?.Invoke(this, null);
            LoadAllStudent?.Invoke(this, null);           
        }

        public event EventHandler CreateList;
        public event EventHandler DeleteTheTest;
        public event EventHandler AddStudent;
        public event EventHandler DeleteStudent;
        public event EventHandler LoadAllExamineeList;
        public event EventHandler LoadStudentOfExamineeList;
        public event EventHandler LoadAllStudent;
        public event EventHandler Update;
        int IManageTheListOfContestants.userID => this.userID;

        DataGridView IManageTheListOfContestants.dgv_allOfStudents { get => dgv_allOfStudents; set => dgv_allOfStudents = value; }
        DataGridView IManageTheListOfContestants.dgv_partListCandidates { get => dgv_partListCandidates; set => dgv_partListCandidates = value; }
        DataGridView IManageTheListOfContestants.dgv_listOfContestants { get => dgv_listOfContestants; set => dgv_listOfContestants = value; }
        TextBox IManageTheListOfContestants.txt_listingCode { get => txt_listingCode; set => txt_listingCode = value; }
        TextBox IManageTheListOfContestants.txt_listName { get => txt_listName; set => txt_listName = value; }

    }
}
