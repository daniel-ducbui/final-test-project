using ExaminationManagement.Forms.CustomMessageBox;
using ExaminationManagement.Forms.Student;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace ExaminationManagement.Forms
{
    public partial class StudentControlPanel : MaterialForm
    {
        int userID;
        public delegate void UserID(int _userID);

        ProfileControlPanel profileControl;
        ExaminationControlPanel examinationControl;
        QuestionControlPanel questionControl;

        public StudentControlPanel()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();

            btn_profile.Click += Btn_profile_Click;
            btn_exam.Click += Btn_exam_Click;
            btn_question.Click += Btn_question_Click;
            btn_logout.Click += Btn_logout_Click;
        }

        public StudentControlPanel(int userID) : this()
        {
            this.userID = userID;
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
