using ExaminationManagement.Forms.Report;
using ExaminationManagement.Presenters.Teacher;
using ExaminationManagement.Views.Teacher;
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
    public partial class StudentManager : MaterialForm, IStudentManager
    {
        StudentManagerPresenter studentManager;

        int userID = 0;
        string errorMessage = null;

        public StudentManager()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += StudentManager_Load;
        }

        public StudentManager(int userID) : this()
        {
            this.userID = userID;
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {
            studentManager = new StudentManagerPresenter(this);

            btn_report.Click += Btn_report_Click;
            btn_back.Click += Btn_back_Click;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            TeacherControlPanel teacherControlPanel = new TeacherControlPanel(this.userID);
            teacherControlPanel.Show();
        }

        private void Btn_report_Click(object sender, EventArgs e)
        {
            int index = dgv_data.SelectedCells[0].RowIndex;
            int _userID = Convert.ToInt32(dgv_data.Rows[index].Cells[0].Value.ToString());

            Teacher_StudentResultReport teacher_StudentResultReport = new Teacher_StudentResultReport(_userID);
            teacher_StudentResultReport.Show();
        }

        int IStudentManager.userID => this.userID;

        string IStudentManager.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        public object dataSource { get => dgv_data.DataSource; set => dgv_data.DataSource = value; }
    }
}
