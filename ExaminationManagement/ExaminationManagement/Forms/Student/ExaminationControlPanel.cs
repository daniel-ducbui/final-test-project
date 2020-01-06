using ExaminationManagement.Forms.Student.Examination;
using ExaminationManagement.Presenters.Student;
using ExaminationManagement.Views.Student;
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

namespace ExaminationManagement.Forms.Student
{
    public partial class ExaminationControlPanel : MaterialForm, IExaminationController
    {
        ExaminationControllerPresenter examController;

        int userID;
        int examID;
        int resultID;
        string testID;

        bool flagChangeTab = false;

        public ExaminationControlPanel()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();

            btn_back.Click += Btn_back_Click;
            btn_result.Click += Btn_result_Click;
            btn_mainExam.Click += Btn_mainExam_Click;
            btn_testExam.Click += Btn_testExam_Click;
            btn_control.Click += Btn_control_Click;
            Load += ExaminationControlPanel_Load;

            dgv_data.DoubleClick += Dgv_data_DoubleClick;
        }

        private void Dgv_data_DoubleClick(object sender, EventArgs e)
        {
            Btn_control_Click(sender, e);
        }

        private void ExaminationControlPanel_Load(object sender, EventArgs e)
        {
            examController = new ExaminationControllerPresenter(this);
        }

        public ExaminationControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void Btn_control_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_data.SelectedCells[0].RowIndex;

                if (this.flagChangeTab)
                {
                    this.examID = Convert.ToInt32(dgv_data.Rows[index].Cells[0].Value.ToString());
                    this.testID = dgv_data.Rows[index].Cells[1].Value.ToString();

                    GetExamInfo?.Invoke(this, null);

                    this.Hide();
                    Examinate examinate = new Examinate(this.userID, this.examID, this.testID);
                    examinate.Show();
                }
                else
                {
                    this.resultID = Convert.ToInt32(dgv_data.Rows[index].Cells[0].Value.ToString());

                    this.Hide();
                    ResultControlPanel resultControlPanel = new ResultControlPanel(this.userID, this.resultID);
                    resultControlPanel.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The examination doesn't have any test! Take a break \nDetails: " + ex.Message);
            }
        }

        private void Btn_testExam_Click(object sender, EventArgs e)
        {
            try
            {
                this.flagChangeTab = true;

                btn_control.Text = "Enroll";

                GetTestExamList?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no examination found! \nDetails: " + ex.Message);
            }
        }

        private void Btn_mainExam_Click(object sender, EventArgs e)
        {
            try
            {
                this.flagChangeTab = true;

                btn_control.Text = "Enroll";

                GetMainExamList?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no examination found! \nDetails: " + ex.Message);
            }
        }

        private void Btn_result_Click(object sender, EventArgs e)
        {
            try
            {
                this.flagChangeTab = false;

                btn_control.Text = "Review";

                GetResult?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no examination found! \nDetails: " + ex.Message);
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentControlPanel studentControlPanel = new StudentControlPanel(this.userID);
            studentControlPanel.Show();
        }

        public event EventHandler GetMainExamList;
        public event EventHandler GetTestExamList;
        public event EventHandler GetResult;
        public event EventHandler GetExamInfo;

        int IExaminationController.userID => this.userID;
        object IExaminationController.dataSource { get => dgv_data.DataSource; set => dgv_data.DataSource = value; }
        string IExaminationController.testID { get => this.testID; set => this.testID = value; }
        int IExaminationController.examID => this.examID;
    }
}
