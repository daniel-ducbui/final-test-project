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

namespace ExaminationManagement.Forms.Teacher.ExaminationController
{
    public partial class ExecuteExamination : MaterialForm, IExecuteExamination
    {
        ExecuteExaminationPresenter examinationPresenter;

        int userID = 0;
        int examinationID = 0;
        string errorMessage = null;

        public ExecuteExamination()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += ExecuteExamination_Load;
        }

        public ExecuteExamination(int userID, int examinationID) : this()
        {
            this.userID = userID;
            this.examinationID = examinationID;
        }

        private void ExecuteExamination_Load(object sender, EventArgs e)
        {
            examinationPresenter = new ExecuteExaminationPresenter(this);

            btn_save.Click += Btn_save_Click;
            btn_create.Click += Btn_create_Click;
            btn_cancel.Click += Btn_cancel_Click;

            if (this.examinationID != 0)
            {
                btn_save.Enabled = true;
                btn_create.Enabled = false;

                // Load old infor
                try
                {
                    LoadExamination?.Invoke(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong! " + ex.Message);
                }
            }
            else
            {
                btn_save.Enabled = false;
                btn_create.Enabled = true;
            }
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                Execute?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Execute?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event EventHandler Execute;
        public event EventHandler LoadExamination;

        int IExecuteExamination.userID => this.userID;
        int IExecuteExamination.examinationID => this.examinationID;
        string IExecuteExamination.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        public string examinationName { get => tb_examinationName.Text; set => tb_examinationName.Text = value; }
        public string testListID { get => cb_testListID.Text; set => cb_testListID.Text = value; }
        public string examineeListID { get => cb_examineeListID.Text; set => cb_examineeListID.Text = value; }
        public string type { get => cb_type.Text; set => cb_type.SelectedItem = value; }
        public string gradeID { get => cb_grade.Text; set => cb_grade.SelectedItem = value; }
        public string time { get => tb_time.Text; set => tb_time.Text = value; }
        public DateTime startDate { get => dtp_startDate.Value; set => dtp_startDate.Value = value; }
        public DateTime endDate { get => dtp_endDate.Value; set => dtp_endDate.Value = value; }

        public object testListIDList { set => cb_testListID.DataSource = value; }
        public object examineeListIDList { set => cb_examineeListID.DataSource = value; }

    }
}
