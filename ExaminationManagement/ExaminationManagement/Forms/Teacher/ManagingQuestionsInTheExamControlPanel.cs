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
    public partial class ManagingQuestionsInTheExamControlPanel : Form, IManagingQuestionsInTheExam
    {
        ManagingQuestionsInTheExamPresenter examManagementPresenter;
        int userID;
        public ManagingQuestionsInTheExamControlPanel(int userID)
        {
            InitializeComponent();
            examManagementPresenter = new ManagingQuestionsInTheExamPresenter(this);
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
        int IManagingQuestionsInTheExam.userID => this.userID;
        DataGridView IManagingQuestionsInTheExam.dgv_questionSection { get => dgv_questionSection; set => dgv_questionSection = value; }
        DataGridView IManagingQuestionsInTheExam.dgv_examInformation { get => dgv_examInformation; set => dgv_examInformation = value; }
        DataGridView IManagingQuestionsInTheExam.dgv_listOfAllTheQuestion { get => dgv_listOfAllTheQuestion; set => dgv_listOfAllTheQuestion = value; }
        TextBox IManagingQuestionsInTheExam.txt_examPaperCode { get => txt_examPaperCode; set => txt_examPaperCode = value; }
        TextBox IManagingQuestionsInTheExam.txt_examName { get => txt_examName; set => txt_examName = value; }

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
