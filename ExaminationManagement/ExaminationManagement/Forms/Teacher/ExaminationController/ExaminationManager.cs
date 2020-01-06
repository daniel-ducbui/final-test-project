using ExaminationManagement.Forms.Teacher.ExaminationController;
using ExaminationManagement.Forms.Teacher.ExamineeController;
using ExaminationManagement.Forms.Teacher.TestController;
using ExaminationManagement.Forms.Teacher.TestController.TheTest;
using ExaminationManagement.Presenters.Teacher.ExaminationManagement;
using ExaminationManagement.Views.Teacher.ExaminationManagement;
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

namespace ExaminationManagement.Forms.Teacher
{
    public partial class ExaminationManager : MaterialForm, IExaminationManagement
    {
        ExaminationManagementPresenter examinationManagement;

        int userID = 0;
        int examinationID = 0;
        string errorMessage = null;

        public ExaminationManager()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += ExaminationManagement_Load;
        }

        public ExaminationManager(int userID) : this()
        {
            this.userID = userID;
        }

        private void ExaminationManagement_Load(object sender, EventArgs e)
        {
            examinationManagement = new ExaminationManagementPresenter(this);

            btn_back.Click += Btn_back_Click;
            btn_createExamination.Click += Btn_createExamination_Click;
            btn_editExamination.Click += Btn_editExamination_Click;
            btn_createExamineeList.Click += Btn_createExamineeList_Click;
            btn_createTestList.Click += Btn_createTestList_Click;
            btn_createTheTest.Click += Btn_createTheTest_Click;
            btn_load.Click += Btn_load_Click;
            btn_detele.Click += Btn_detele_Click;
            dgv_data.DoubleClick += Dgv_data_DoubleClick;
            
            this.LoadExamination();
        }

        private void Dgv_data_DoubleClick(object sender, EventArgs e)
        {
            Btn_editExamination_Click(sender, e);
        }

        void LoadExamination()
        {
            try
            {
                LoadData?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show("Something wrong!" + this.errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong!" + this.errorMessage + "\n" + ex.Message);
            }
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            this.LoadExamination();
        }

        private void Btn_editExamination_Click(object sender, EventArgs e)
        {
            int index = dgv_data.SelectedCells[0].RowIndex;
            this.examinationID = Convert.ToInt32(dgv_data.Rows[index].Cells[0].Value.ToString());

            // Call edit form
            ExecuteExamination executeExamination = new ExecuteExamination(this.userID, this.examinationID);
            executeExamination.ShowDialog();
        }

        private void Btn_createExamination_Click(object sender, EventArgs e)
        {
            // Call edit form
            ExecuteExamination executeExamination = new ExecuteExamination(this.userID, this.examinationID);
            executeExamination.ShowDialog();
        }

        private void Btn_createTestList_Click(object sender, EventArgs e)
        {
            this.Hide();

            TestListManagement theTest = new TestListManagement(this.userID);
            theTest.Show();
        }

        private void Btn_createTheTest_Click(object sender, EventArgs e)
        {
            this.Hide();

            TestManagement testManagement = new TestManagement(this.userID);
            testManagement.Show();
        }

        private void Btn_createExamineeList_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExamineeListManagement examineeManagement = new ExamineeListManagement(this.userID);
            examineeManagement.Show();
        }

        private void Btn_detele_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_data.SelectedCells[0].RowIndex;
                this.examinationID = Convert.ToInt32(dgv_data.Rows[index].Cells[0].Value.ToString());

                Delete?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong!" + ex.Message);  
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            TeacherControlPanel teacherControlPanel = new TeacherControlPanel(this.userID);
            teacherControlPanel.Show();
        }

        public event EventHandler LoadData;
        public event EventHandler Delete;

        int IExaminationManagement.userID => this.userID;
        int IExaminationManagement.examinationID { get => this.examinationID; set => this.examinationID = value; }
        public object dataSource { get => dgv_data.DataSource; set => dgv_data.DataSource = value; }
        string IExaminationManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
    }
}
