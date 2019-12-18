using ExaminationManagement.Forms.Student;
using ExaminationManagement.Forms.Student.Profile;
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

namespace ExaminationManagement.Forms
{
    public partial class StudentControlPanel : Form, IProfile
    {
        ExaminationControlPanel examinationControlPanel;
        AddQuestionControlPanel addQuestionControlPanel;
        ResultExaminationControlPanel resultExaminationControlPanel;
        CalendarExaminationControlPanel calendarExaminationControlPanel;

        ProfilePresenter profilePresenter;

        int userID;

        // NOTE: Khi sử dụng userID chỉ cần gọi this.userID
        public void GetUserID(int _userID)
        {
            this.userID = _userID;
        }

        public StudentControlPanel()
        {
            InitializeComponent();

            Load += StudentControlPanel_Load;
            btn_examination.Click += Btn_examination_Click;
            btn_addQuestion.Click += Btn_addQuestion_Click;
            btn_calendarExamination.Click += Btn_calendarExamination_Click;
            btn_resultExamination.Click += Btn_resultExamination_Click;
            btn_save.Click += Btn_save_Click;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                profilePresenter = new ProfilePresenter(this);
                SaveProfile?.Invoke(this, null);

                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        private void StudentControlPanel_Load(object sender, EventArgs e)
        {
            profilePresenter = new ProfilePresenter(this);
            LoadProfile?.Invoke(this, null);
        }

        private void Btn_resultExamination_Click(object sender, EventArgs e)
        {
            this.Hide();

            resultExaminationControlPanel = new ResultExaminationControlPanel();
            resultExaminationControlPanel.FormClosed += (s, args) => this.Close();
            resultExaminationControlPanel.Show();
        }

        private void Btn_calendarExamination_Click(object sender, EventArgs e)
        {
            this.Hide();

            calendarExaminationControlPanel = new CalendarExaminationControlPanel();
            calendarExaminationControlPanel.FormClosed += (s, args) => this.Close();
            calendarExaminationControlPanel.Show();
        }

        private void Btn_addQuestion_Click(object sender, EventArgs e)
        {
            addQuestionControlPanel = new AddQuestionControlPanel(this.userID);
            addQuestionControlPanel.ShowDialog();
        }

        private void Btn_examination_Click(object sender, EventArgs e)
        {
            examinationControlPanel = new ExaminationControlPanel(this.userID);
            examinationControlPanel.ShowDialog();
        }

        public event EventHandler SaveProfile;
        public event EventHandler LoadProfile;

        public TextBox name { get => txt_name; set => txt_name = value; }
        public TextBox phoneNumber { get => txt_phoneNumber; set => txt_phoneNumber = value; }
        public TextBox email { get => txt_email; set => txt_email = value; }
        public MaskedTextBox dob { get => mtb_dob; set => mtb_dob = value; }
        public TextBox address { get => txt_address; set => txt_address = value; }
        public TextBox ClassID { get => txt_class; set => txt_class = value; }
        public TextBox gradeID { get => txt_gradelID; set => txt_gradelID = value; }
        int IProfile.userID => this.userID;
    }
}
