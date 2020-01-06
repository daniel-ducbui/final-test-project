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
    public partial class ExaminationResultReport : MaterialForm
    {
        public ExaminationResultReport()
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

        private void BtnView_Click(object sender, EventArgs e)
        {
            rptExamResult.LocalReport.DataSources.Clear();
            using (var examination = new ExaminationManagementDataContext())
            {
                examination.DeferredLoadingEnabled = false;

                //Examination
                var examationBS = new BindingSource();
                var rDSExamination = new ReportDataSource("examination");
                rDSExamination.Value = examationBS;
                rptExamResult.LocalReport.DataSources.Add(rDSExamination);

                var loa = new DataLoadOptions();
                loa.LoadWith<TheExamination>(t => t.ExaminationName);
                var ex = (from exam in examination.TheExaminations
                          where exam.ExaminationName == cbb_examination.Text
                          select new
                          {
                              exam.ExaminationName,
                              exam.TestListID,
                              exam.Time
                          }).ToList();

                examationBS.DataSource = ex;

                //Result
                var resultBS = new BindingSource();
                var rDSResult = new ReportDataSource("result");
                rDSResult.Value = resultBS;
                rptExamResult.LocalReport.DataSources.Add(rDSResult);

                var lo = new DataLoadOptions();
                lo.LoadWith<Result>(rs => rs.UserID);
                var results = (from exam in examination.TheExaminations
                               join rs in examination.Results on exam.ExaminationID equals rs.ExaminationID
                               where exam.ExaminationName == cbb_examination.Text
                               select new
                               {
                                   rs.UserID,
                                   rs.TestID,
                                   rs.TotalScore,

                               }).ToList();
                resultBS.DataSource = results;
            }
            this.rptExamResult.RefreshReport();
        }

        private void ExaminationResultReport_Load(object sender, EventArgs e)
        {
            LoadAllExamination();
            this.rptExamResult.RefreshReport();
        }

        void LoadAllExamination()
        {
            using (var examination = new ExaminationManagementDataContext())
            {
                var exam = examination.TheExaminations.Select(e => e.ExaminationName).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = exam;
                cbb_examination.DataSource = bs;
            }
        }
    }
}
