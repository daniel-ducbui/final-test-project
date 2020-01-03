using ExaminationManagement.Presenters;
using ExaminationManagement.Views;
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
    public partial class AdminControlPanel : MaterialForm, IAccountManagement
    {
        AccountManagementPresenter accountManagementPresenter;
        string ErrorMessage = null;

        int userID;

        public AdminControlPanel()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();

            Load += AdminControlPanel_Load;

            btn_loadData.Click += Btn_loadData_Click;
            btn_readData.Click += Btn_readData_Click;
            btn_add.Click += Btn_add_Click;
        }

        // NOTE: Khi sử dụng userID chỉ cần gọi this.userID

        public void GetUserID(int _userID)
        {
            this.userID = _userID;
        }

        private void AdminControlPanel_Load(object sender, EventArgs e)
        {
            this.cb_table.SelectedIndex = 0;
            accountManagementPresenter = new AccountManagementPresenter(this);
            try
            {
                LoadData?.Invoke(this, null);
            }
            catch (Exception)
            {
                MessageBox.Show(accountManagementPresenter.ErrorMessage);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser?.Invoke(this, null);
                MessageBox.Show(accountManagementPresenter.ErrorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(accountManagementPresenter.ErrorMessage);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.userID.ToString()); // Test lấy userID
        }

        private void Btn_readData_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportUser?.Invoke(this, null);
                if (!String.IsNullOrEmpty(ErrorMessage))
                {
                    MessageBox.Show(accountManagementPresenter.ErrorMessage);
                }
            }
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Clear current user id
            this.userID = -1;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void cb_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData?.Invoke(this, null);
        }

        public int _userID => this.userID;
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
        public object DataSource { get => this.dgv_table.DataSource; set => this.dgv_table.DataSource = value; }
        public string fileName { get => this.openFileDialog1.FileName.ToString(); }
        public string selectedTable { get => this.cb_table.SelectedIndex.ToString(); }

        public event EventHandler LoadData;
        public event EventHandler AddUser;
        public event EventHandler EditUser;
        public event EventHandler ImportUser;
    }
}
