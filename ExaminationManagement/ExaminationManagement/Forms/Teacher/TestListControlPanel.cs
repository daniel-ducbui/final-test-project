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
    public partial class TestListControlPanel : Form, ITestList
    {
        TestListPresenter testListPresenter;
        int userID;
        public TestListControlPanel(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            testListPresenter = new TestListPresenter(this);
            btn_back.Click += Btn_back_Click;
            Load += TestListControlPanel_Load;
            btn_createTheTest.Click += Btn_createTheTest_Click;
            btn_addTheTest.Click += Btn_addTheTest_Click;
            btn_deleteTheTest.Click += Btn_deleteTheTest_Click;
            btn_update.Click += Btn_update_Click;
            btn_delete.Click += Btn_delete_Click;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Delete?.Invoke(this, null);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Update?.Invoke(this, null);
        }

        private void Btn_deleteTheTest_Click(object sender, EventArgs e)
        {
            DeleteTheTest?.Invoke(this, null);
        }

        private void Btn_createTheTest_Click(object sender, EventArgs e)
        {
            CreateTheTest?.Invoke(this, null);
        }

        private void Btn_addTheTest_Click(object sender, EventArgs e)
        {
            AddTheTest?.Invoke(this, null);
        }

        private void TestListControlPanel_Load(object sender, EventArgs e)
        {
            LoadAllTheTest?.Invoke(this, null);
            LoadTheTestOfTestList?.Invoke(this, null);
            LoadAllTestList?.Invoke(this, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler CreateTheTest;
        public event EventHandler Update;
        public event EventHandler Delete;
        public event EventHandler AddTheTest;
        public event EventHandler DeleteTheTest;
        public event EventHandler LoadAllTheTest;
        public event EventHandler LoadTheTestOfTestList;
        public event EventHandler LoadAllTestList;

        int ITestList.userID => this.userID;

        DataGridView ITestList.dgv_allTheTest { get => dgv_allTheTest; set => dgv_allTheTest = value; }
        DataGridView ITestList.dgv_partOfTheExam { get => dgv_partOfTheExam; set => dgv_partOfTheExam = value; }
        DataGridView ITestList.dgv_listOfAllExamQuestions { get => dgv_listOfAllExamQuestions; set => dgv_listOfAllExamQuestions =value; }
        TextBox ITestList.txt_testID { get => txt_testID; set => txt_testID = value; }
        TextBox ITestList.txt_testName { get => txt_testName; set => txt_testName = value; }
    }
}
