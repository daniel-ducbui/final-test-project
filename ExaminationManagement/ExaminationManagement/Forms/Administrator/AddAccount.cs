using ExaminationManagement.Presenters.Administator;
using ExaminationManagement.Views.Administator;
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

namespace ExaminationManagement.Forms.Administrator
{
    public partial class AddAccount : MaterialForm, IAddAccount
    {
        AddAccountPresenter addAccount;

        public AddAccount()
        {
            InitializeComponent();

            Load += AddAccount_Load;
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            addAccount = new AddAccountPresenter(this);

            btn_cancel.Click += Btn_cancel_Click;
            btn_add.Click += Btn_add_Click;
            btn_save.Click += Btn_save_Click;
        }

        int userID = 0;
        int _userID = 0;

        public AddAccount(int userID, int _userID) : this()
        {
            this.userID = userID;
            this._userID = _userID;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Save?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser?.Invoke(this, null);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler AddUser;
        public event EventHandler Save;

        int IAddAccount.userID { get => this.userID; set => this.userID = value; }
        int IAddAccount._userID { get => this._userID; set => this._userID = value; }
        public string name { get => this.tb_name.Text; set => this.tb_name.Text = value; }
        public string phoneNumber { get => this.tb_phoneNumber.Text; set => this.tb_phoneNumber.Text = value; }
        public string email { get => this.tb_email.Text; set => this.tb_email.Text = value; }
        public string dob { get => this.mtb_dob.Text; set => this.mtb_dob.Text = value; }
        public string address { get => this.tb_address.Text; set => this.tb_address.Text = value; }
        public string classID { get => this.tb_classID.Text; set => this.tb_classID.Text = value; }
        public string gradeID { get => this.tb_gradeID.Text; set => this.tb_gradeID.Text = value; }
        public string accountType { get => this.cb_permission.SelectedItem.ToString(); set => this.cb_permission.SelectedItem = value; }
        public string password { get => this.tb_password.Text; set => this.tb_password.Text = value; }
    }
}
