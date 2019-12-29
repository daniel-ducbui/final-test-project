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
    public partial class ProfileControlPanel : Form, IProfile
    {
        ProfilePresenter profilePresenter;

        public ProfileControlPanel()
        {
            InitializeComponent();
        }

        int userID;
        public ProfileControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void ProfileControlPanel_Load(object sender, EventArgs e)
        {
            profilePresenter = new ProfilePresenter(this);
            tb_id.Text = this.userID.ToString();
            LoadInfo?.Invoke(this, null);

            btn_cancel.Click += Btn_cancel_Click;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentControlPanel studentControlPanel = new StudentControlPanel(this.userID);
            studentControlPanel.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveInfo?.Invoke(this, null);
                MessageBox.Show(profilePresenter.ErrorMessage);
            }
            catch (Exception)
            {
                MessageBox.Show(profilePresenter.ErrorMessage);
            }
        }

        public int _userID => this.userID;

        public TextBox name { get => tb_name; set => tb_name = value; }
        public TextBox phoneNumber { get => tb_phoneNumber; set => tb_phoneNumber = value; }
        public TextBox email { get => tb_email; set => tb_email = value; }
        public MaskedTextBox dob { get => mtb_dob; set => mtb_dob = value; }
        public TextBox address { get => tb_address; set => tb_address = value; }
        public TextBox classID { get => tb_class; set => tb_class = value; }
        public TextBox gradeID { get => tb_grade; set => tb_grade = value; }

        public event EventHandler SaveInfo;
        public event EventHandler LoadInfo;
    }
}
