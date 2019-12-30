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
    public partial class ExamManagementControlPanel : Form, IExamManagement
    {
        ExamManagementPresenter examManagementPresenter;
        int userID;
        public ExamManagementControlPanel(int userID)
        {
            InitializeComponent();
            examManagementPresenter = new ExamManagementPresenter(this);
            this.userID = userID;
            Load += ExamManagementControlPanel_Load;
            btn_createTest.Click += Btn_createTest_Click;
            btn_deleteTheTest.Click += Btn_deleteTheTest_Click;
            btn_update.Click += Btn_update_Click;
            btn_addTheQuestion.Click += Btn_addTheQuestion_Click;
            btn_deleteTheQuestion.Click += Btn_deleteTheQuestion_Click;
            btn_back.Click += Btn_back_Click;
        }

        private void Btn_deleteTheQuestion_Click(object sender, EventArgs e)
        {
            DeleteTheQuestion?.Invoke(this, null);
        }

        private void Btn_addTheQuestion_Click(object sender, EventArgs e)
        {
            AddTheQuestion?.Invoke(this, null);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Update?.Invoke(this, null);
        }

        private void Btn_deleteTheTest_Click(object sender, EventArgs e)
        {
            DeleteTheTest?.Invoke(this, null);
        }

        private void Btn_createTest_Click(object sender, EventArgs e)
        {
            CreateTest?.Invoke(this, null);
        }

        private void ExamManagementControlPanel_Load(object sender, EventArgs e)
        {
            LoadAllQuestion?.Invoke(this, null);
            LoadAllTheTest?.Invoke(this, null);
            LoadQuestionOfTheTest?.Invoke(this, null);
        }
        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int IExamManagement.userID => this.userID;
        DataGridView IExamManagement.dgv_questionSection { get => dgv_questionSection; set => dgv_questionSection = value; }
        DataGridView IExamManagement.dgv_examInformation { get => dgv_examInformation; set => dgv_examInformation = value; }
        DataGridView IExamManagement.dgv_listOfAllTheQuestion { get => dgv_listOfAllTheQuestion; set => dgv_listOfAllTheQuestion = value; }
        TextBox IExamManagement.txt_examPaperCode { get => txt_examPaperCode; set => txt_examPaperCode = value; }
        TextBox IExamManagement.txt_examName { get => txt_examName; set => txt_examName = value; }

        public event EventHandler CreateTest;
        public event EventHandler Update;
        public event EventHandler DeleteTheTest;
        public event EventHandler AddTheQuestion;
        public event EventHandler DeleteTheQuestion;
        public event EventHandler LoadAllQuestion;
        public event EventHandler LoadAllTheTest;
        public event EventHandler LoadQuestionOfTheTest;
    }
}
