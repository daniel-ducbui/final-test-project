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
    public partial class TestListDetailsManagement : MaterialForm, ITestListDetailsManagement
    {
        TestDetailsManagementPresenter testDetailsManagementPresenter;

        List<string> testListIDList;

        int userID = 0;
        string testListID = null;
        string errorMessage = null;
        bool signal = false;

        public TestListDetailsManagement()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += TestListDetailsManagement_Load;
            btn_back.Click += Btn_back_Click;
            btn_add.Click += Btn_add_Click;
            btn_delete.Click += Btn_delete_Click;
        }

        void ExecuteList(bool signal)
        {
            try
            {
                testListIDList = new List<string>();

                this.signal = signal;

                if (signal)
                {
                    var selectedRows = dgv_theTests.SelectedRows
                        .OfType<DataGridViewRow>()
                        .Where(r => !r.IsNewRow)
                        .ToList();

                    foreach (var item in selectedRows)
                    {
                        testListIDList.Add(item.Cells[0].Value.ToString());
                    }
                }
                else
                {
                    var selectedRows = dgv_testListDetails.SelectedRows
                                            .OfType<DataGridViewRow>()
                                            .Where(r => !r.IsNewRow)
                                            .ToList();

                    foreach (var item in selectedRows)
                    {
                        testListIDList.Add(item.Cells[1].Value.ToString());
                    }
                }

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                }

                Execute?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            this.ExecuteList(true);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            this.ExecuteList(false);
        }

        public TestListDetailsManagement(int userID, string testListID) : this()
        {
            this.userID = userID;
            this.testListID = testListID;
        }

        private void TestListDetailsManagement_Load(object sender, EventArgs e)
        {
            testDetailsManagementPresenter = new TestDetailsManagementPresenter(this);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            TestListManagement testListManagement = new TestListManagement(this.userID);
            testListManagement.Show();
        }

        int ITestListDetailsManagement.userID => this.userID;

        string ITestListDetailsManagement.testListID => this.testListID;

        public object testListDetails { get => dgv_testListDetails.DataSource; set => dgv_testListDetails.DataSource = value; }
        public object theTests { get => dgv_theTests.DataSource; set => dgv_theTests.DataSource = value; }
        string ITestListDetailsManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        List<string> ITestListDetailsManagement.testListIDList { get => this.testListIDList; set => this.testListIDList = value; }
        bool ITestListDetailsManagement.signal { get => this.signal; set => this.signal = value; }

        public event EventHandler Execute;
    }
}
