using ExaminationManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationManagement.Functions;
using ExaminationManagement.Views;
using ExaminationManagement.Presenters;

namespace ExaminationManagement
{
    public partial class LoginForm : Form, ILogin
    {
        // Call login presenter
        LoginPresenter loginPresenter;
        AdminControlPanel adminControlPanel;
        TeacherControlPanel teacherControlPanel;
        StudentControlPanel studentControlPanel;

        // Khởi tạo delegate truyền userID
        int _userID;
        public delegate void UserID(int _userID);

        public LoginForm()
        {
            InitializeComponent();
            Load += LoginForm_Load;
            btn_quit.Click += Btn_quit_Click;
        }

        private void Btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Initialize login view
            loginPresenter = new LoginPresenter(this);

            // Rise error if connect to database failed 
            if (!String.IsNullOrEmpty(loginPresenter.ErrorMessage))
            {
                MessageBox.Show(loginPresenter.ErrorMessage);
                return;
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            // Redirect to login presenter to authenticating account
            int checking = loginPresenter.Authenticating();

            // Check the return result
            if (checking == -1) // Authenticating failed
            {
                MessageBox.Show(loginPresenter.ErrorMessage); // Rise error message
            }
            else // Authentication success
            {
                // Check the permission of each type of account 
                // 0 ~ admin
                // 1 ~ teacher
                // 2 ~ student
                // Then show Form according to the permission
                this.Hide();
                if (checking == 0)
                {
                    adminControlPanel = new AdminControlPanel();
                    adminControlPanel.FormClosed += (s, args) => this.Close();

                    // Truyền userID hiện tại
                    UserID userID = new UserID(adminControlPanel.GetUserID);
                    userID(this._userID);

                    adminControlPanel.Show();
                }
                else if (checking == 1)
                {
                    teacherControlPanel = new TeacherControlPanel();
                    teacherControlPanel.FormClosed += (s, args) => this.Close();

                    // Truyền userID hiện tại
                    UserID userID = new UserID(teacherControlPanel.GetUserID);
                    userID(this._userID);

                    teacherControlPanel.Show();
                }
                else if (checking == 2)
                {
                    studentControlPanel = new StudentControlPanel();
                    studentControlPanel.FormClosed += (s, args) => this.Close();

                    // Truyền userID hiện tại
                    UserID userID = new UserID(studentControlPanel.GetUserID);
                    userID(this._userID);

                    studentControlPanel.Show();
                }
                else // Non determined error
                {
                    MessageBox.Show("Lag");
                }
            }
        }

        public int userID { get => this._userID; set => this._userID = value; }
        public string username { get => tb_username.Text; }
        public string password { get => tb_password.Text; }

        public bool isMatched
        {
            get; set;
        }
    }
}
