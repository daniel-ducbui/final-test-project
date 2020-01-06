using ExaminationManagement.Functions.ConnectDatabase;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Report
{
    public partial class Teacher_StudentResultReport : MaterialForm
    {
        int userID = 0;

        public Teacher_StudentResultReport()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500,
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();
            btn_view.Click += BtnView_Click;
        }

        public Teacher_StudentResultReport(int userID) : this()
        {
            this.userID = userID;
        }

        private void Teacher_StudentResultReport_Load(object sender, EventArgs e)
        {
            this.rptStudentResult.RefreshReport();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            rptStudentResult.LocalReport.DataSources.Clear();

            using (var examination = new ExaminationManagementDataContext())
            {
                examination.DeferredLoadingEnabled = false;
                var resultBS = new BindingSource();
                var rDS = new ReportDataSource("result");
                rDS.Value = resultBS;
                rptStudentResult.LocalReport.DataSources.Add(rDS);

                var lo = new DataLoadOptions();
                lo.LoadWith<Result>(ac => ac.UserID);
                var results = (from exam in examination.TheExaminations
                               join rs in examination.Results on exam.ExaminationID equals rs.ExaminationID
                               where rs.UserID == this.userID
                               select new
                               {
                                   rs.ExaminationID,
                                   rs.UserID,
                                   rs.TestID,
                                   rs.TotalScore,

                               }).ToList();
                resultBS.DataSource = results;
            }

            this.rptStudentResult.RefreshReport();
        }
    }
}
