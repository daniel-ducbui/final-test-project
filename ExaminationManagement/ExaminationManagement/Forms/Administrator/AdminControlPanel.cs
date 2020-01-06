using ExaminationManagement.Forms.Administrator;
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
            btn_edit.Click += Btn_edit_Click;
            btn_logout.Click += Btn_logout_Click;
            cb_table.SelectedIndexChanged += Cb_table_SelectedIndexChanged;
            dgv_table.DoubleClick += Dgv_table_DoubleClick;
        }

        private void Dgv_table_DoubleClick(object sender, EventArgs e)
        {
            Btn_edit_Click(sender, e);
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.userID = -1;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        public AdminControlPanel(int userID) : this()
        {
            this.userID = userID;
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

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            int index = dgv_table.SelectedCells[0].RowIndex;
            int _userID = Convert.ToInt32(dgv_table.Rows[index].Cells[0].Value.ToString());

            AddAccount addAccount = new AddAccount(this.userID, _userID);
            addAccount.ShowDialog();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount(this.userID, 0);
            addAccount.ShowDialog();
        }

        private void Btn_readData_Click(object sender, EventArgs e)
        {
            if (openUserDataFile.ShowDialog() == DialogResult.OK)
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

        private void Cb_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData?.Invoke(this, null);
        }

        public int _userID => this.userID;
        public string searchContent { get => this.tb_search.Text; set => this.tb_search.Text = value; }
        public object DataSource { get => this.dgv_table.DataSource; set => this.dgv_table.DataSource = value; }
        public string fileName { get => this.openUserDataFile.FileName.ToString(); }
        public string selectedTable { get => this.cb_table.SelectedIndex.ToString(); }

        public event EventHandler LoadData;
        public event EventHandler ImportUser;
    }
}
