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
    public partial class StudentListReport : MaterialForm
    {
        public StudentListReport()
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

        private void StudentListReport_Load(object sender, EventArgs e)
        {
            LoadAllExamination();
            this.rptStudentList.RefreshReport();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            rptStudentList.LocalReport.DataSources.Clear();
            using (var examination = new ExaminationManagementDataContext())
            {
                examination.DeferredLoadingEnabled = false;
                var examineeBS = new BindingSource();
                var rDS = new ReportDataSource("acount_detail");
                rDS.Value = examineeBS;
                rptStudentList.LocalReport.DataSources.Add(rDS);

                var lo = new DataLoadOptions();
                lo.LoadWith<AccountDetail>(ac => ac.UserID);
                var examinees = (from exam in examination.TheExaminations
                                 join examinee in examination.ExamineeListDetails on exam.ExamineeListID equals examinee.ExamineeListID
                                 join acd in examination.AccountDetails on examinee.UserID equals acd.UserID
                                 where exam.ExaminationName == cbb_examination.Text
                                 select new
                                 {
                                     acd.UserID,
                                     acd.Name,
                                     acd.DOB,
                                     acd.ClassID,
                                     acd.GradeID,
                                 }).ToList();

                examineeBS.DataSource = examinees;
                ReportParameter examinationName = new ReportParameter("examinationName");
                examinationName.Values.Add(cbb_examination.Text);
                this.rptStudentList.LocalReport.SetParameters(examinationName);

            }
            this.rptStudentList.RefreshReport();
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
