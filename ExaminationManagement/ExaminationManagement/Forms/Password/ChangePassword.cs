using ExaminationManagement.Presenters.Password;
using ExaminationManagement.Views.Password;
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

namespace ExaminationManagement.Forms.Password
{
    public partial class ChangePassword : MaterialForm, IChangePassword
    {
        ChangePasswordPresenter changePassword;

        int userID = 0;
        string errorMessage = null;
        bool flagSuccess = false;

        public ChangePassword()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            InitializeComponent();

            Load += ChangePassword_Load;
            btn_cancel.Click += Btn_cancel_Click;
            btn_confirm.Click += Btn_confirm_Click;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            changePassword = new ChangePasswordPresenter(this);
        }

        public ChangePassword(int userID) : this()
        {
            this.userID = userID;
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                Confirm?.Invoke(this, null);

                MessageBox.Show(this.errorMessage);

                if (this.flagSuccess)
                {
                    this.Close();
                }
                else
                {
                    //tb_oldPassword.Text = null;
                    //tb_newPassword.Text = null;
                    //tb_confirmNewPassword = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail!" + ex.Message);
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int IChangePassword.userID => this.userID;
        public string oldPassword { get => this.tb_oldPassword.Text; set => this.tb_oldPassword.Text = value; }
        public string newPassword { get => this.tb_newPassword.Text; set => this.tb_newPassword.Text = value; }
        public string confirmNewPassword { get => this.tb_confirmNewPassword.Text; set => this.tb_confirmNewPassword.Text = value; }
        bool IChangePassword.flagSuccess { get => this.flagSuccess; set => this.flagSuccess = value; }
        string IChangePassword.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        public event EventHandler Confirm;
    }
}
