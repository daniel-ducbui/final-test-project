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
    public partial class ProfileControlPanel : MaterialForm, IProfile
    {
        ProfilePresenter profilePresenter;

        public ProfileControlPanel()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            btn_save.Click += Btn_save_Click;
        }

        private void Btn_save_Click(object sender, EventArgs e)
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

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentControlPanel studentControlPanel = new StudentControlPanel(this.userID);
            studentControlPanel.Show();
        }

        public int _userID => this.userID;

        public LollipopTextBox name { get => tb_name; set => tb_name = value; }
        public LollipopTextBox phoneNumber { get => tb_phoneNumber; set => tb_phoneNumber = value; }
        public LollipopTextBox email { get => tb_email; set => tb_email = value; }
        public MaskedTextBox dob { get => mtb_dob; set => mtb_dob = value; }
        public LollipopTextBox address { get => tb_address; set => tb_address = value; }
        public LollipopTextBox classID { get => tb_class; set => tb_class = value; }
        public LollipopTextBox gradeID { get => tb_grade; set => tb_grade = value; }

        public event EventHandler SaveInfo;
        public event EventHandler LoadInfo;
    }
}
