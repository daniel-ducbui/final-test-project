using ExaminationManagement.Forms.Student;
using ExaminationManagement.Forms.Teacher;
using MaterialSkin.Controls;
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
    public partial class TeacherControlPanel : MaterialForm
    {
        int userID;

        public TeacherControlPanel()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();

            Load += TeacherControlPanel_Load;
        }

        public TeacherControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void TeacherControlPanel_Load(object sender, EventArgs e)
        {
            btn_examination.Click += Btn_examination_Click;
            btn_student.Click += Btn_student_Click;
            btn_question.Click += Btn_question_Click;
            btn_logout.Click += Btn_logout_Click;
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void Btn_question_Click(object sender, EventArgs e)
        {
            this.Hide();

            QuestionControlPanel questionControlPanel = new QuestionControlPanel(this.userID);
            questionControlPanel.Show();
        }

        private void Btn_student_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentManager studentManagement = new StudentManager(this.userID);
            studentManagement.Show();
        }

        private void Btn_examination_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExaminationManager examinationManager = new ExaminationManager(this.userID);
            examinationManager.Show();
        }
    }
}
