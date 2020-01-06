namespace ExaminationManagement.Forms.Report
{
    partial class QuestionExporter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TheQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptQuestion = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TheQuestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TheQuestionBindingSource
            // 
            this.TheQuestionBindingSource.DataSource = typeof(ExaminationManagement.Functions.ConnectDatabase.TheQuestion);
            // 
            // rptQuestion
            // 
            reportDataSource1.Name = "question";
            reportDataSource1.Value = this.TheQuestionBindingSource;
            this.rptQuestion.LocalReport.DataSources.Add(reportDataSource1);
            this.rptQuestion.LocalReport.ReportEmbeddedResource = "ExaminationManagement.Forms.Report.rptExportQuestion.rdlc";
            this.rptQuestion.Location = new System.Drawing.Point(0, 64);
            this.rptQuestion.Name = "rptQuestion";
            this.rptQuestion.ServerReport.BearerToken = null;
            this.rptQuestion.Size = new System.Drawing.Size(800, 386);
            this.rptQuestion.TabIndex = 0;
            // 
            // QuestionExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptQuestion);
            this.Name = "QuestionExporter";
            this.Text = "Question Exporter";
            this.Load += new System.EventHandler(this.QuestionExporter_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TheQuestionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptQuestion;
        private System.Windows.Forms.BindingSource TheQuestionBindingSource;
    }
}