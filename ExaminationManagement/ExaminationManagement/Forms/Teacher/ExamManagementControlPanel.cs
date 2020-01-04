using ExaminationManagement.Presenters.Teacher;
using ExaminationManagement.Views.Tearcher;
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
    public partial class ExamManagementControlPanel : Form, IExamManagement
    {
        ExamManagementPresenter examManagementPresenter;
        int userID;
        public ExamManagementControlPanel(int userID)
        {

            InitializeComponent();
            this.userID = userID;
            examManagementPresenter = new ExamManagementPresenter(this);
            btn_back.Click += Btn_back_Click;
            Load += ExamManagementControlPanel_Load;
            btn_createExam.Click += Btn_createExam_Click;
            btn_update.Click += Btn_update_Click;
            btn_deleteTheExam.Click += Btn_deleteTheExam_Click;
            btn_createExamList.Click += Btn_createExamList_Click;
            btn_createTheExamSet.Click += Btn_createTheExamSet_Click;
        }

        private void Btn_createTheExamSet_Click(object sender, EventArgs e)
        {
            CreateTheExamSet?.Invoke(this, null);
        }

        private void Btn_createExamList_Click(object sender, EventArgs e)
        {
            CreateExamList?.Invoke(this, null);
        }

        private void Btn_deleteTheExam_Click(object sender, EventArgs e)
        {
            Delete?.Invoke(this, null);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Update?.Invoke(this, null);
        }

        private void Btn_createExam_Click(object sender, EventArgs e)
        {
            CreateExam?.Invoke(this, null);
        }

        private void ExamManagementControlPanel_Load(object sender, EventArgs e)
        {
            LoadAllExamination?.Invoke(this, null);
            LoadAllExamineeList?.Invoke(this, null);
            LoadAllTestList?.Invoke(this, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int IExamManagement.userID => this.userID;

        TextBox IExamManagement.txt_examName { get => txt_examName; set => txt_examName =value; }
        ComboBox IExamManagement.ccb_kindOfExam { get => ccb_kindOfExam; set => ccb_kindOfExam = value; }
        ComboBox IExamManagement.ccb_selectTheExamList { get => ccb_selectTheExamList; set => ccb_selectTheExamList = value; }
        ComboBox IExamManagement.ccb_chooseTheTestSet { get => ccb_chooseTheTestSet; set => ccb_chooseTheTestSet = value; }
        ComboBox IExamManagement.ccb_chooseGrade { get => ccb_chooseGrade; set => ccb_chooseGrade = value; }
        MaskedTextBox IExamManagement.mtb_startDay { get => mtb_startDay; set => mtb_startDay = value; }
        MaskedTextBox IExamManagement.mtb_endDay { get => mtb_endDay; set => mtb_endDay = value; }
        TextBox IExamManagement.txt_time { get => txt_time; set => txt_time = value; }
        DataGridView IExamManagement.dgv_allExams { get => dgv_allExams; set => dgv_allExams = value; }

        public event EventHandler CreateExam;
        public event EventHandler CreateExamList;
        public event EventHandler CreateTheExamSet;
        public event EventHandler Update;
        public event EventHandler Delete;
        public event EventHandler SeeTheListOfExaminee;
        public event EventHandler SeeTheResult;
        public event EventHandler ComboboxOnlySelect;
        public event EventHandler LoadAllExamination;
        public event EventHandler LoadAllExamineeList;
        public event EventHandler LoadAllTestList;
    }
}
