using ExaminationManagement.Forms.Student.Examination;
using ExaminationManagement.Presenters.Student;
using ExaminationManagement.Views.Student;
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
    public partial class ExaminationControlPanel : Form, IExaminationController
    {
        ExaminationControllerPresenter examController;
        public ExaminationControlPanel()
        {
            InitializeComponent();

            btn_back.Click += Btn_back_Click;
            btn_exam.Click += Btn_exam_Click;
            btn_result.Click += Btn_result_Click;
            btn_mainExam.Click += Btn_mainExam_Click;
            btn_testExam.Click += Btn_testExam_Click;
            btn_enroll.Click += Btn_enroll_Click;
            Load += ExaminationControlPanel_Load;
        }

        private void ExaminationControlPanel_Load(object sender, EventArgs e)
        {
            examController = new ExaminationControllerPresenter(this);
        }

        string testID;
        int userID;
        int examID;

        public ExaminationControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void Btn_enroll_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_examInfo.SelectedCells[0].RowIndex;
                this.examID = Convert.ToInt32(dgv_examInfo.Rows[index].Cells[0].Value.ToString());
                this.testID = dgv_examInfo.Rows[index].Cells[1].Value.ToString();

                GetExamInfo?.Invoke(this, null);

                this.Hide();
                Examinate examinate = new Examinate(this.userID, this.examID, this.testID);
                examinate.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The examination doesn't have any test! Take a break \nDetails: " + ex.Message);
            }
        }

        private void Btn_testExam_Click(object sender, EventArgs e)
        {
            pnl_exam.Size = new Size(1019, 449);
            pnl_mainExam.Visible = true;
            pnl_mainExam.Location = new Point(3, 76);
            pnl_mainExam.Size = new Size(1011, 368);
            btn_enroll.Location = new Point(870, 300);
            btn_enroll.Size = new Size(136, 63);

            try
            {
                GetTestExamList?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no examination found! \nDetails: " + ex.Message);
            }

            dgv_examInfo.Location = new Point(3, 3);
            dgv_examInfo.Size = new Size(860, 360);
        }

        private void Btn_mainExam_Click(object sender, EventArgs e)
        {

            pnl_exam.Size = new Size(1019, 449);
            pnl_mainExam.Visible = true;
            pnl_mainExam.Location = new Point(3, 76);
            pnl_mainExam.Size = new Size(1011, 368);
            btn_enroll.Location = new Point(870, 300);
            btn_enroll.Size = new Size(136, 63);

            try
            {
                GetMainExamList?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no examination found! \nDetails: " + ex.Message);
            }

            dgv_examInfo.Location = new Point(3, 3);
            dgv_examInfo.Size = new Size(860, 360);
        }

        private void Btn_result_Click(object sender, EventArgs e)
        {
            ResultControlPanel resultControlPanel = new ResultControlPanel(this.userID);
            resultControlPanel.ShowDialog();
        }

        private void Btn_exam_Click(object sender, EventArgs e)
        {
            if (!pnl_exam.Visible)
            {
                pnl_exam.Visible = true;
                pnl_exam.Location = new Point(12, 86);

                if (pnl_mainExam.Visible)
                {
                    pnl_exam.Size = new Size(1019, 449);
                }
                else
                {
                    pnl_exam.Size = new Size(1019, 80);
                }
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
        public event EventHandler GetExamInfo;

        int IExaminationController.userID => this.userID;
        object IExaminationController.examList { get => dgv_examInfo.DataSource; set => dgv_examInfo.DataSource = value; }
        string IExaminationController.testID { get => this.testID; set => this.testID = value; }
        int IExaminationController.examID => this.examID;
    }
}
