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
                _resultDetailsBS.DataSource = _data.ResultDetails.ToList();
            }

            this.rpv_result.RefreshReport();
        }
    }
}
