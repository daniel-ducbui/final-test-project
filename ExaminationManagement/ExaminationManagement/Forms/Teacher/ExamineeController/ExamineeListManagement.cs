using ExaminationManagement.Presenters.Teacher.ExamineeController;
using ExaminationManagement.Views.Teacher.ExamineeController;
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

namespace ExaminationManagement.Forms.Teacher.ExamineeController
{
    public partial class ExamineeListManagement : MaterialForm, IExamineeListManagement
    {
        ExamineeListManagementPresenter examineeManagementPresenter;

        int userID = 0;
        int examineeListID = 0;
        string errorMessage = null;
        bool signal = false;
        bool flagEdit = false;

        public ExamineeListManagement()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += ExamineeManagement_Load;
            btn_back.Click += Btn_back_Click;
            btn_delete.Click += Btn_delete_Click;
            btn_create.Click += Btn_create_Click;
            btn_examineeManager.Click += Btn_examineeManager_Click; ;
            btn_cancel.Click += Btn_cancel_Click;
            dgv_examinee.DoubleClick += Dgv_examinee_DoubleClick;
        }

        private void Dgv_examinee_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_examinee.SelectedCells[0].RowIndex;
                this.examineeListID = Convert.ToInt32(dgv_examinee.Rows[index].Cells[0].Value.ToString());

                ShowExaminee?.Invoke(this, null);

                tb_examineeListID.Text = Convert.ToString(this.examineeListID);
                this.flagEdit = true;

                this.OnEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_examineeManager_Click(object sender, EventArgs e)
        {
            this.Hide();

            int index = dgv_examinee.SelectedCells[0].RowIndex;
            this.examineeListID = Convert.ToInt32(dgv_examinee.Rows[index].Cells[0].Value.ToString());

            ExamineeListDetailsManagement examineeListDetailsManagement = new ExamineeListDetailsManagement(this.userID, this.examineeListID);
            examineeListDetailsManagement.Show();
        }

        public ExamineeListManagement(int userID) : this()
        {
            this.userID = userID;
        }

        private void ExamineeManagement_Load(object sender, EventArgs e)
        {
            examineeManagementPresenter = new ExamineeListManagementPresenter(this);

            btn_cancel.Hide();
        }

        void ExecuteExaminee(bool signal)
        {
            try
            {
                if (!signal || flagEdit)
                {
                    int index = dgv_examinee.SelectedCells[0].RowIndex;
                    this.examineeListID = Convert.ToInt32(dgv_examinee.Rows[index].Cells[0].Value.ToString());
                }
                this.flagEdit = false;
                this.signal = signal;

                Execute?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                    this.OnClear();
                    this.OnEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_create_Click(object sender, EventArgs e)
        {
            ExecuteExaminee(true);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            ExecuteExaminee(false);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExaminationManager examinationManager = new ExaminationManager(this.userID);
            examinationManager.Show();
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.flagEdit = false;

            this.OnEdit();
            this.OnClear();
        }

        void OnEdit()
        {
            if (this.flagEdit)
            {
                btn_cancel.Show();
            }
            else
            {
                btn_cancel.Hide();
            }
        }

        void OnClear()
        {
            tb_examineeListID.Text = null;
            tb_examineeName.Text = null;

            tb_examineeListID.Select();
        }

        public int uesrID => this.userID;

        int IExamineeListManagement.examineeListID { get => examineeListID; set => examineeListID = value; }
        public string examineeName { get => tb_examineeName.Text; set => tb_examineeName.Text = value; }
        public object examineeList { get => dgv_examinee.DataSource; set => dgv_examinee.DataSource = value; }
        string IExamineeListManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        bool IExamineeListManagement.signal { get => this.signal; set => this.signal = value; }

        public event EventHandler Execute;
        public event EventHandler ShowExaminee;
    }
}
