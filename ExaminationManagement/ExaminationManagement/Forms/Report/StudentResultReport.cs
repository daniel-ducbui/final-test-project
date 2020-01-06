using ExaminationManagement.Forms.Student;
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
    public partial class StudentResultReport : MaterialForm
    {
        public StudentResultReport()
        {
            InitializeComponent();

            btn_back.Click += Btn_back_Click;
        }

        int userID;
        int resultID;

        public StudentResultReport(int userID, int resultID) : this()
        {
            this.userID = userID;
            this.resultID = resultID;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ResultControlPanel resultPanel = new ResultControlPanel(this.userID, this.resultID);
            resultPanel.Show();
        }

        private void StudentResultReport_Load(object sender, EventArgs e)
        {
            rpv_result.LocalReport.DataSources.Clear();

            using (var _data = new ExaminationManagementDataContext())
            {
                var _resultDetailsBS = new BindingSource();
                var reportDS = new ReportDataSource("result_details");
                reportDS.Value = _resultDetailsBS;
                rpv_result.LocalReport.DataSources.Add(reportDS);

                var loadOption = new DataLoadOptions();
                loadOption.LoadWith<ResultDetail>(r => r.Result);
                _data.LoadOptions = loadOption;
                var rsDetail = (from rs in _data.Results
                                 join rsdtail in _data.ResultDetails on rs.ResultID equals rsdtail.ResultID
                                 where rs.ResultID == resultID
                                 select new
                                 {
                                     rsdtail.QuestionID,
                                     rsdtail.Answer,
                                     rsdtail.Score,

                                 }).ToList();
                _resultDetailsBS.DataSource = rsDetail;

                // 

                //acountDetail
                var examationBS = new BindingSource();
                var rDSExamination = new ReportDataSource("account_details");
                rDSExamination.Value = examationBS;
                rpv_result.LocalReport.DataSources.Add(rDSExamination);

                var loa = new DataLoadOptions();
                loa.LoadWith<AccountDetail>(ac => ac.UserID);
                var ex = (from result in _data.Results
                          join ac in _data.AccountDetails on result.UserID equals ac.UserID
                          where result.UserID == userID && result.ResultID == this.resultID
                          select new
                          {
                              ac.UserID,
                              ac.Name,
                              ac.DOB,
                              ac.ClassID,
                          }).ToList();

                examationBS.DataSource = ex;

                //result
                var resultBS = new BindingSource();
                var rDS = new ReportDataSource("result");
                rDS.Value = resultBS;
                rpv_result.LocalReport.DataSources.Add(rDS);

                var lo = new DataLoadOptions();
                lo.LoadWith<Result>(ac => ac.UserID);
                var results = (from rs in _data.Results
                               where rs.UserID == userID && rs.ResultID == this.resultID
                               select new
                               {
                                   rs.ExaminationID,
                                   rs.UserID,
                                   rs.TestID,
                                   rs.TotalScore,

                               }).ToList();
                resultBS.DataSource = results;

                //examName
                var exam = _data.TheExaminations.SingleOrDefault(ex => ex.ExaminationID == results.Select(r => r.ExaminationID).FirstOrDefault());
                // con cho nao can report nua khong
                //No duoc roi ak, tai d' co ki thi do
                //con 3 cai do
                // m chep cai cua m qua luon di
                ReportParameter examinationName = new ReportParameter("examinationName");
                examinationName.Values.Add(exam.ExaminationName.ToString());
                this.rpv_result.LocalReport.SetParameters(examinationName);
            }

            this.rpv_result.RefreshReport();
        }
    }
}
// Khoan