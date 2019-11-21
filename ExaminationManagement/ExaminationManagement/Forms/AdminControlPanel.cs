using ExaminationManagement.Presenters;
using ExaminationManagement.Views;
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
    public partial class AdminControlPanel : Form, IAccountManagement
    {
        AccountManagementPresenter accountManagementPresenter;
        string ErrorMessage = null;

        public AdminControlPanel()
        {
            InitializeComponent();
            Load += AdminControlPanel_Load;

            btn_loadData.Click += Btn_loadData_Click;
            btn_readData.Click += Btn_readData_Click;
            btn_add.Click += Btn_add_Click;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke(this, null);
            if (String.IsNullOrEmpty(ErrorMessage))
            {
                MessageBox.Show(accountManagementPresenter.ErrorMessage);
            }
        }

        private void Btn_readData_Click(object sender, EventArgs e)
        {
            ImportUser?.Invoke(this, null);
        }

        private void Btn_loadData_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        private void AdminControlPanel_Load(object sender, EventArgs e)
        {
            accountManagementPresenter = new AccountManagementPresenter(this);
            LoadData?.Invoke(this, null);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        public string searchContent { get => this.tb_search.Text; set => this.tb_search.Text = value; }
        public string name { get => this.tb_name.Text; set => this.tb_name.Text = value; }
        public string phoneNumber { get => this.tb_phoneNumber.Text; set => this.tb_phoneNumber.Text = value; }
        public string email { get => this.tb_email.Text; set => this.tb_email.Text = value; }
        public string dob { get => this.mtb_dob.Text; set => this.mtb_dob.Text = value; }
        public string address { get => this.tb_address.Text; set => this.tb_address.Text = value; }
        public string classID { get => this.tb_classID.Text; set => this.tb_classID.Text = value; }
        public string gradeID { get => this.tb_gradeID.Text; set => this.tb_gradeID.Text = value; }
        public string accountType { get => this.cb_accountType.SelectedItem.ToString(); }
        public string password { get => this.tb_password.Text; set => this.tb_password.Text = value; }
        public object DataSource { get => this.dgv_accounts.DataSource; set => this.dgv_accounts.DataSource = value; }

        public event EventHandler LoadData;
        public event EventHandler AddUser;
        public event EventHandler EditUser;
        public event EventHandler ImportUser;
    }
}
