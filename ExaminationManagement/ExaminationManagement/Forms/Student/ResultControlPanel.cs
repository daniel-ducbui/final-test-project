using ExaminationManagement.Presenters.Student;
using ExaminationManagement.Views.Student.Examination;
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
    public partial class ResultControlPanel : MaterialForm, IResult
    {
        ResultPresenter result;

        int userID = 0;
        int resultID = 0;
        string name = null;

        string examinationName = null;
        string testID = null;
        int times = 0;
        int totalScore = 0;

        public ResultControlPanel()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();

            btn_back.Click += Btn_back_Click;
            btn_print.Click += Btn_print_Click;
            Load += ResultControlPanel_Load;
        }

        public ResultControlPanel(int userID, int resultID) : this()
        {
            this.userID = userID;
            this.resultID = resultID;
        }

        private void ResultControlPanel_Load(object sender, EventArgs e)
        {
            result = new ResultPresenter(this);

            LoadResultDetails();
        }

        void LoadResultDetails()
        {
            try
            {
                GetResultDetails?.Invoke(this, null);

                /// Student information card
                lsc_info.Text = this.name;
                lsc_info.Info = Convert.ToString(this.userID);

                /// Result information
                // Examination name
                tb_examinationName.Text = this.examinationName;
                // Result ID
                tb_resultID.Text = Convert.ToString(this.resultID);
                // Test ID
                tb_testID.Text = this.testID;
                // Times
                tb_times.Text = Convert.ToString(this.times);
                // Total score
                lb_totalScore.Text = Convert.ToString(this.totalScore);

                if (this.totalScore < 5)
                {
                    lb_totalScore.ForeColor = Color.Red;
                }
                else if (this.totalScore >= 5 && this.totalScore <= 9)
                {
                    lb_totalScore.ForeColor = Color.DarkGoldenrod;
                }
                else
                {
                    lb_totalScore.ForeColor = Color.Blue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExaminationControlPanel examinationControl = new ExaminationControlPanel(this.userID);
            examinationControl.Show();
        }

        public event EventHandler GetResultDetails;

        int IResult.userID => this.userID;

        int IResult.resultID => this.resultID;
        int IResult.totalScore { get => this.totalScore; set => this.totalScore = value; }
        string IResult.name { get => this.name; set => this.name = value; }
        string IResult.examinationName { get => this.examinationName; set => this.examinationName = value; }
        string IResult.testID { get => this.testID; set => this.testID = value; }
        int IResult.times { get => this.times; set => this.times = value; }

        object IResult.dataSource { get => this.dgv_data.DataSource; set => this.dgv_data.DataSource = value; }
    }
}
