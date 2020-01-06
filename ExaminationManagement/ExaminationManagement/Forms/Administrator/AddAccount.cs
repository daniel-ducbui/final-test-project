using ExaminationManagement.Functions.Validation;
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
using System.Text.RegularExpressions;
using System.Globalization;

namespace ExaminationManagement.Forms.Administrator
{
    public partial class AddAccount : MaterialForm, IAddAccount
    {
        AddAccountPresenter addAccount;

        int flagValidation = 0;
        string onlyLetterPattern = @"^\b[A-Z][ a-zA-Z]*$";
        string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        string phoneNumberParttern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d{9}$";
        string dobPattern = @"^(\d{1,2})/(\d{1,2})/(\d{4})$";
        string onlyNumberPattern = @"^\d{2}$";
        string passwordPattern = @"^[a-z0-9]{5,9}$";

        public AddAccount()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            InitializeComponent();

            Load += AddAccount_Load;

        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            addAccount = new AddAccountPresenter(this);

            btn_cancel.Click += Btn_cancel_Click;
            btn_add.Click += Btn_add_Click;
            btn_save.Click += Btn_save_Click;

            tb_name.Select();
            this.flagValidation = 0;

            tb_name.Validating += Tb_name_Validating;
            tb_phoneNumber.Validating += Tb_phoneNumber_Validating;
            tb_email.Validating += Tb_email_Validating;
            tb_address.Validating += Tb_address_Validating;
            mtb_dob.Validating += Mtb_dob_Validating;
            tb_classID.Validating += Tb_classID_Validating;
            tb_gradeID.Validating += Tb_gradeID_Validating;
            tb_password.Validating += Tb_password_Validating;
            cb_permission.Validating += Cb_permission_Validating;
        }

        private void Mtb_dob_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;

            if (string.IsNullOrEmpty(mtb_dob.Text.Trim()))
            {
                errorProviderMain.SetError(mtb_dob, "Required field");
            }
            else if (!Regex.Match(mtb_dob.Text, dobPattern).Success)
            {
                errorProviderMain.SetError(mtb_dob, "Invalid date");
            }
            else
            {
                try
                {
                    DateTime dt = DateTime.ParseExact(mtb_dob.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    DateTime dateStart = DateTime.Now.AddYears(-20);
                    DateTime dateEnd = DateTime.Now;

                    if (dateStart <= dt && dt <= dateEnd)
                    {
                        errorProviderMain.SetError(mtb_dob, string.Empty);
                        this.flagValidation = 0;
                    }
                    else
                    {
                        errorProviderMain.SetError(mtb_dob, "20 years ago");
                    }
                }
                catch (Exception)
                {
                    errorProviderMain.SetError(mtb_dob, "dd/MM/yyyy");
                }
            }
        }

        private void Cb_permission_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (cb_permission.SelectedItem == null)
            {
                errorProviderMain.SetError(cb_permission, "Required field");
            }
            else
            {
                errorProviderMain.SetError(cb_permission, string.Empty);
                this.flagValidation = 0;
            }
        }

        private void Tb_password_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (string.IsNullOrEmpty(tb_password.Text.Trim()))
            {
                errorProviderMain.SetError(tb_password, "Required field");
            }
            else if (!Regex.Match(tb_password.Text, passwordPattern).Success)
            {
                errorProviderMain.SetError(tb_password, "Password must be 6-10 characters");
            }
            else
            {
                errorProviderMain.SetError(tb_password, string.Empty);
                this.flagValidation = 0;
            }
        }

        private void Tb_gradeID_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (string.IsNullOrEmpty(tb_gradeID.Text.Trim()))
            {
                errorProviderMain.SetError(tb_gradeID, "Required field");
            }
            else if (!Regex.Match(tb_gradeID.Text, onlyNumberPattern).Success)
            {
                errorProviderMain.SetError(tb_gradeID, "Grade 10 - 12 only");
            }
            else
            {
                errorProviderMain.SetError(tb_gradeID, string.Empty);
                this.flagValidation = 0;
            }
        }

        private void Tb_classID_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (string.IsNullOrEmpty(tb_classID.Text.Trim()))
            {
                errorProviderMain.SetError(tb_classID, "Required field");
            }
            else
            {
                errorProviderMain.SetError(tb_classID, string.Empty);
                this.flagValidation = 0;
            }
        }

        private void Tb_address_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (string.IsNullOrEmpty(tb_address.Text.Trim()))
            {
                errorProviderMain.SetError(tb_address, "Required field");
            }
            else
            {
                errorProviderMain.SetError(tb_address, string.Empty);
                this.flagValidation = 0;
            }
        }

        private void Tb_email_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (string.IsNullOrEmpty(tb_email.Text.Trim()))
            {
                errorProviderMain.SetError(tb_email, "Required field");
            }
            else if (!Regex.Match(tb_email.Text, emailPattern).Success)
            {
                errorProviderMain.SetError(tb_email, "Wrong email type!");
            }
            else
            {
                errorProviderMain.SetError(tb_email, string.Empty);
                this.flagValidation = 0;
            }
        }

        private void Tb_phoneNumber_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (string.IsNullOrEmpty(tb_phoneNumber.Text.Trim()))
            {
                errorProviderMain.SetError(tb_phoneNumber, "Required field");
            }
            else if (!Regex.Match(tb_phoneNumber.Text, phoneNumberParttern).Success)
            {
                errorProviderMain.SetError(tb_phoneNumber, "Wrong phone number type!");
            }
            else
            {
                errorProviderMain.SetError(tb_phoneNumber, string.Empty);
                this.flagValidation = 0;
            }
        }

        private void Tb_name_Validating(object sender, CancelEventArgs e)
        {
            this.flagValidation = 1;
            if (string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                errorProviderMain.SetError(tb_name, "Required field");
            }
            else if (!Regex.Match(tb_name.Text, onlyLetterPattern).Success)
            {
                errorProviderMain.SetError(tb_name, "Invalid name");
            }
            else
            {
                errorProviderMain.SetError(tb_name, string.Empty);
                this.flagValidation = 0;
            }
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
                if (this.flagValidation == 0)
                {
                    Save?.Invoke(this, null);

                    if (!string.IsNullOrEmpty(addAccount.ErrorMessage))
                    {
                        MessageBox.Show(addAccount.ErrorMessage);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input!");
                }
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
                if (this.flagValidation == 0)
                {
                    AddUser?.Invoke(this, null);


                    if (!string.IsNullOrEmpty(addAccount.ErrorMessage))
                    {
                        MessageBox.Show(addAccount.ErrorMessage);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input!");
                }
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
