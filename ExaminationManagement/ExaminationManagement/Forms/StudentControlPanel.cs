using ExaminationManagement.Forms.Student;
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
    public partial class StudentControlPanel : Form
    {
        int userID;
        public delegate void UserID(int _userID);

        ProfileControlPanel profileControl;
        ExaminationControlPanel examinationControl;
        QuestionControlPanel questionControl;
        ResultControlPanel resultControl;

        public StudentControlPanel()
        {
            InitializeComponent();

            btn_profile.Click += Btn_profile_Click;
            btn_exam.Click += Btn_exam_Click;
            btn_question.Click += Btn_question_Click;
            btn_back.Click += Btn_back_Click;
        }

        public StudentControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void Btn_result_Click(object sender, EventArgs e)
        {
            this.Hide();

            resultControl = new ResultControlPanel(this.userID);
            resultControl.Show();
        }

        private void Btn_question_Click(object sender, EventArgs e)
        {
            this.Hide();

            questionControl = new QuestionControlPanel(this.userID);
            questionControl.Show();
        }

        private void Btn_exam_Click(object sender, EventArgs e)
        {
            this.Hide();

            examinationControl = new ExaminationControlPanel(this.userID);
            examinationControl.Show();
        }

        private void Btn_profile_Click(object sender, EventArgs e)
        {
            this.Hide();

            profileControl = new ProfileControlPanel(this.userID);
            profileControl.Show();
        }

        // NOTE: Khi sử dụng userID chỉ cần gọi this.userID
        public void GetUserID(int _userID)
        {
            this.userID = _userID;
        }
    }
}
