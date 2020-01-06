using ExaminationManagement.Presenters.Teacher.TestController.TheTest;
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
    public partial class TestDetailsManagement : MaterialForm, ITestDetailsManagement
    {
        TestDetailsManagementPresenter testDetailsPresenter;
        List<int> questionIDList;

        int userID = 0;
        string testID = null;
        string errorMessage = null;
        bool signal = false;

        public TestDetailsManagement()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += TestDetailsManagement_Load;
            btn_back.Click += Btn_back_Click;
            btn_delete.Click += Btn_delete_Click;
            btn_add.Click += Btn_add_Click;
        }

        public TestDetailsManagement(int userID, string testID) : this()
        {
            this.userID = userID;
            this.testID = testID;
        }

        private void TestDetailsManagement_Load(object sender, EventArgs e)
        {
            testDetailsPresenter = new TestDetailsManagementPresenter(this);
        }

        void Execute(bool signal)
        {
            try
            {
                questionIDList = new List<int>();

                this.signal = signal;

                if (signal)
                {
                    var selectedRows = dgv_theQuestions.SelectedRows
                        .OfType<DataGridViewRow>()
                        .Where(r => !r.IsNewRow)
                        .ToList();

                    foreach (var item in selectedRows)
                    {
                        questionIDList.Add(Convert.ToInt32(item.Cells[0].Value.ToString()));
                    }
                }
                else
                {
                    var selectedRows = dgv_testDetails.SelectedRows
                                            .OfType<DataGridViewRow>()
                                            .Where(r => !r.IsNewRow)
                                            .ToList();

                    foreach (var item in selectedRows)
                    {
                        questionIDList.Add(Convert.ToInt32(item.Cells[1].Value.ToString()));
                    }
                }

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                }

                ExecuteTest?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Execute(true);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Execute(false);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            TestManagement testManagement = new TestManagement(this.userID);
            testManagement.Show();
        }

        int ITestDetailsManagement.userID => this.userID;

        string ITestDetailsManagement.testID => this.testID;

        string ITestDetailsManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }

        public object theQuestions { get => dgv_theQuestions.DataSource; set => dgv_theQuestions.DataSource = value; }
        public object testDetails { get => dgv_testDetails.DataSource; set => dgv_testDetails.DataSource = value; }
        bool ITestDetailsManagement.signal { get => this.signal; set => this.signal = value; }
        List<int> ITestDetailsManagement.questionIDList { get => this.questionIDList; set => this.questionIDList = value; }

        public event EventHandler ExecuteTest;
    }
}
