using ExaminationManagement.Presenters.Teacher.TestController;
using ExaminationManagement.Views.Teacher.TestController;
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

namespace ExaminationManagement.Forms.Teacher.TestController
{
    public partial class TestListManagement : MaterialForm, ITestListManagement
    {
        TestListManagementPresenter testManagementPresenter;

        int userID = 0;
        string errorMessage = null;
        bool signal = true;
        bool flagEdit = false;

        public TestListManagement()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += TheTestManagement_Load;
            btn_delete.Click += Btn_delete_Click;
            btn_edit.Click += Btn_edit_Click;
            btn_create.Click += Btn_create_Click;
            btn_testManager.Click += Btn_testManager_Click;
            dgv_testList.DoubleClick += Dgv_testList_DoubleClick;
        }

        public TestListManagement(int userID) : this()
        {
            this.userID = userID;
        }

        private void Btn_testManager_Click(object sender, EventArgs e)
        {
            this.Hide();

            int index = dgv_testList.SelectedCells[0].RowIndex;
            this.testListID = dgv_testList.Rows[index].Cells[0].Value.ToString();

            TestListDetailsManagement testListDetailsManagement = new TestListDetailsManagement(this.userID, this.testListID);
            testListDetailsManagement.Show();
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                this.signal = true;

                Execute?.Invoke(this, null);

                //this.flagEdit = false;

                //this.OnEdit();

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails" + this.errorMessage);
            }
        }

        private void Dgv_testList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_testList.SelectedCells[0].RowIndex;
                this.testListID = dgv_testList.Rows[index].Cells[0].Value.ToString();

                //this.flagEdit = true;

                //this.OnEdit();

                ShowTestList?.Invoke(this, null);
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong! \nDetails" + this.errorMessage);
            }
        }

        void OnEdit()
        {
            if (this.flagEdit)
            {
                btn_create.Text = "Save";
                //btn_edit.Enabled = true;
            }
            else
            {
                btn_create.Text = "Create";
                //btn_edit.Enabled = false;
            }
        }

        void OnClear()
        {
            tb_testListID.Text = null;
            tb_testListName.Text = null;

            tb_testListID.Select();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                this.signal = true;

                int index = dgv_testList.SelectedCells[0].RowIndex;
                this.testListID = dgv_testList.Rows[index].Cells[0].Value.ToString();

                Execute?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                }
                this.OnClear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong! \nDetails" + this.errorMessage);
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                this.signal = false;

                int index = dgv_testList.SelectedCells[0].RowIndex;
                this.testListID = dgv_testList.Rows[index].Cells[0].Value.ToString();

                Execute?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                }
                this.OnClear();
            }
            catch (Exception)
            {
                MessageBox.Show("Something wrong! \nDetails" + this.errorMessage);
            }
        }

        private void TheTestManagement_Load(object sender, EventArgs e)
        {
            testManagementPresenter = new TestListManagementPresenter(this);

            btn_back.Click += Btn_back_Click;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExaminationManager examinationManager = new ExaminationManager(this.userID);
            examinationManager.Show();
        }

        string ITestListManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        public object testList { get => dgv_testList.DataSource; set => dgv_testList.DataSource = value; }

        int ITestListManagement.userID => this.userID;
        public string testListID { get => tb_testListID.Text; set => tb_testListID.Text = value; }
        public string testListName { get => tb_testListName.Text; set => tb_testListName.Text = value; }
        bool ITestListManagement.signal { get => this.signal; set => this.signal = value; }

        public event EventHandler Execute;
        public event EventHandler ShowTestList;
    }
}
