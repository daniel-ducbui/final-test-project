using ExaminationManagement.Presenters.Teacher.TestController;
using ExaminationManagement.Views.Teacher.TestController;
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

namespace ExaminationManagement.Forms.Teacher.TestController
{
    public partial class TheTestManagement : MaterialForm, ITheTestManagement
    {
        TheTestManagementPresenter testManagementPresenter;

        int userID = 0;
        string errorMessage = null;

        public TheTestManagement()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += TheTestManagement_Load;
        }

        public TheTestManagement(int userID) : this()
        {
            this.userID = userID;
        }

        private void TheTestManagement_Load(object sender, EventArgs e)
        {
            testManagementPresenter = new TheTestManagementPresenter(this);

            btn_back.Click += Btn_back_Click;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExaminationManager examinationManager = new ExaminationManager(this.userID);
            examinationManager.Show();
        }

        string ITheTestManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        public object testList { get => dgv_testList.DataSource; set => dgv_testList.DataSource = value; }
        //public object testListDetails { get => dgv_testListDetails.DataSource; set => dgv_testListDetails.DataSource = value; }

        int ITheTestManagement.userID => this.userID;

        public event EventHandler LoadQuestion;

        private void dgv_testList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
