using ExaminationManagement.Forms.Teacher;
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

namespace ExaminationManagement.Forms
{
    public partial class TeacherControlPanel : Form, IProfile
    {
        QuestionManagementControlPanel questionManagementControlPanel;
        ManagingQuestionsInTheExamControlPanel managingQuestionsInTheExamControlPanel;
        ExamManagementControlPanel examManagementControlPanel;
        int userID;

        public TeacherControlPanel()
        {
            InitializeComponent();
            btn_questionManagement.Click += Btn_questionManagement_Click;
            btn_managingQuestionsInTheExam.Click += Btn_managingQuestionsInTheExam_Click;
            btn_examManagement.Click += Btn_examManagement_Click;
        }

        private void Btn_examManagement_Click(object sender, EventArgs e)
        {
            examManagementControlPanel = new ExamManagementControlPanel(this.userID);
            examManagementControlPanel.ShowDialog();
        }

        private void Btn_managingQuestionsInTheExam_Click(object sender, EventArgs e)
        {
            managingQuestionsInTheExamControlPanel = new ManagingQuestionsInTheExamControlPanel(this.userID);
            managingQuestionsInTheExamControlPanel.ShowDialog();
        }
        public TeacherControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void Btn_questionManagement_Click(object sender, EventArgs e)
        {
            questionManagementControlPanel = new QuestionManagementControlPanel(this.userID);
            questionManagementControlPanel.ShowDialog();
        }
        int IProfile.userID => this.userID;
    }
}
