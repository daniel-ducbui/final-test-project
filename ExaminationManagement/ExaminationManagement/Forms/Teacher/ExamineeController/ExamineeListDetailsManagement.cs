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
    public partial class ExamineeListDetailsManagement : MaterialForm, IExamineeListDetailsManagement
    {
        ExamineeListDetailsManegementPresenter presenter;
        List<int> examineeListIDList;

        int userID = 0;
        int examineeListID = 0;
        string errorMessage = null;
        bool signal = false;

        public ExamineeListDetailsManagement()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += ExamineeListDetailsManagement_Load;
            btn_back.Click += Btn_back_Click;
            btn_delete.Click += Btn_delete_Click;
            btn_add.Click += Btn_add_Click;
        }

        public ExamineeListDetailsManagement(int userID, int examineeListID) : this()
        {
            this.userID = userID;
            this.examineeListID = examineeListID;
        }

        private void ExamineeListDetailsManagement_Load(object sender, EventArgs e)
        {
            presenter = new ExamineeListDetailsManegementPresenter(this);
        }

        void Execute(bool signal)
        {
            try
            {
                examineeListIDList = new List<int>();

                this.signal = signal;

                if (signal)
                {
                    var selectedRows = dgv_examineeList.SelectedRows
                        .OfType<DataGridViewRow>()
                        .Where(r => !r.IsNewRow)
                        .ToList();

                    foreach (var item in selectedRows)
                    {
                        examineeListIDList.Add(Convert.ToInt32(item.Cells[0].Value.ToString()));
                    }
                }
                else
                {
                    var selectedRows = dgv_examineeDetails.SelectedRows
                                            .OfType<DataGridViewRow>()
                                            .Where(r => !r.IsNewRow)
                                            .ToList();

                    foreach (var item in selectedRows)
                    {
                        examineeListIDList.Add(Convert.ToInt32(item.Cells[1].Value.ToString()));
                    }
                }

                ExecuteExaminee?.Invoke(this, null);

                if (!string.IsNullOrEmpty(this.errorMessage))
                {
                    MessageBox.Show(this.errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! " + ex.Message);
            }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Execute(true);
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            Execute(false);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExamineeListManagement examineeList = new ExamineeListManagement(this.userID);
            examineeList.Show();
        }

        public object examineeList { get => dgv_examineeList.DataSource; set => dgv_examineeList.DataSource = value; }
        public object examineeListDetails { get => dgv_examineeDetails.DataSource; set => dgv_examineeDetails.DataSource = value; }
        

        int IExamineeListDetailsManagement.userID => this.userID;

        int IExamineeListDetailsManagement.examineeListID => this.examineeListID;

        string IExamineeListDetailsManagement.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        bool IExamineeListDetailsManagement.signal { get => this.signal; set => this.signal = value; }
        List<int> IExamineeListDetailsManagement.examineeListIDList { get => this.examineeListIDList; set => this.examineeListIDList = value; }

        public event EventHandler ExecuteExaminee;
    }
}
