using ExaminationManagement.Views.Teacher.TestController.TheTest;
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

namespace ExaminationManagement.Forms.Teacher.TestController.TheTest
{
    public partial class TestManagement : MaterialForm, ITheTestManagement
    {
        TheTestPresenter testPresenter;

        int userID = 0;
        string errorMessage = null;
        bool signal = false;
        bool flagEdit = false;

        public TestManagement()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += TestManagement_Load;
            btn_back.Click += Btn_back_Click;
            btn_delete.Click += Btn_delete_Click;
            btn_create.Click += Btn_create_Click;
            btn_testManager.Click += Btn_testManager_Click;
            btn_cancel.Click += Btn_cancel_Click;
            dgv_theTest.DoubleClick += Dgv_theTest_DoubleClick;
        }

        public TestManagement(int userID) : this()
        {
            this.userID = userID;
        }

        private void TestManagement_Load(object sender, EventArgs e)
        {
            testPresenter = new TheTestPresenter(this);

            btn_cancel.Hide();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.flagEdit = false;

            this.OnEdit();
            this.OnClear();
        }

        private void Dgv_theTest_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_theTest.SelectedCells[0].RowIndex;
                this.testID = dgv_theTest.Rows[index].Cells[0].Value.ToString();
                this.flagEdit = true;

                this.OnEdit();

                ShowTest?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        void OnEdit()
        {
            if (this.flagEdit)
            {
                btn_cancel.Show();
            }
            else
            {
                btn_cancel.Hide();
            }
        }

        void OnClear()
        {
            tb_testID.Text = null;
            tb_testName.Text = null;

            tb_testID.Select();
        }

        private void Btn_testManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            int index = dgv_theTest.SelectedCells[0].RowIndex;
            this.testID = dgv_theTest.Rows[index].Cells[0].Value.ToString();

            TestDetailsManagement testDetailsManagement = new TestDetailsManagement(this.userID, this.testID);
            testDetailsManagement.Show();
        }

        void ExecuteTest(bool signal)
        {
            try
            {
                if (!signal || flagEdit)
                {
                    int index = dgv_theTest.SelectedCells[0].RowIndex;
                    this.testID = dgv_theTest.Rows[index].Cells[0].Value.ToString();
                }
                this.flagEdit = false;
                this.signal = signal;

                Execute?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                    this.OnClear();
                    this.OnEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            ExecuteTest(true);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            ExecuteTest(false);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExaminationManager examinationManager = new ExaminationManager(this.userID);
            examinationManager.Show();
        }

        string ITheTestManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        public string testID { get => tb_testID.Text; set => tb_testID.Text = value; }
        public string testName { get => tb_testName.Text; set => tb_testName.Text = value; }
        public object theTests { get => dgv_theTest.DataSource; set => dgv_theTest.DataSource = value; }
        bool ITheTestManagement.signal { get => this.signal; set => this.signal = value; }

        int ITheTestManagement.userID => this.userID;

        public event EventHandler Execute;
        public event EventHandler ShowTest;
    }
}
