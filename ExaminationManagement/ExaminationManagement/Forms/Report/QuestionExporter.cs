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
    public partial class QuestionExporter : MaterialForm
    {
        int userID = 0;

        public QuestionExporter()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            InitializeComponent();

            Load += QuestionExporter_Load_1;
        }

        public QuestionExporter(int userID) : this()
        {
            this.userID = userID;
        }

        private void QuestionExporter_Load(object sender, EventArgs e)
        {

        }

        private void QuestionExporter_Load_1(object sender, EventArgs e)
        {
            rptQuestion.LocalReport.DataSources.Clear();
            using (var examination = new ExaminationManagementDataContext())
            {
                examination.DeferredLoadingEnabled = false;

                //Question
                var questionBS = new BindingSource();
                var rDSquestion = new ReportDataSource("question");
                rDSquestion.Value = questionBS;
                rptQuestion.LocalReport.DataSources.Add(rDSquestion);

                var loa = new DataLoadOptions();
                loa.LoadWith<TheQuestion>(t => t.QuestionID);
                var ex = examination.TheQuestions.ToList();
                questionBS.DataSource = ex;


            }
            this.rptQuestion.RefreshReport();
        }

        // Start here 
    }
}
