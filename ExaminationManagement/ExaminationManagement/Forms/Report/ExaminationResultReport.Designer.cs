namespace ExaminationManagement.Forms.Report
{
    partial class ExaminationResultReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TheExaminationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.rptExamResult = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_view = new LollipopButton();
            this.cbb_examination = new MetroFramework.Controls.MetroComboBox();
            this.lollipopLabel1 = new LollipopLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TheExaminationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TheExaminationBindingSource
            // 
            this.TheExaminationBindingSource.DataSource = typeof(ExaminationManagement.Functions.ConnectDatabase.TheExamination);
            // 
            // ResultBindingSource
            // 
            this.ResultBindingSource.DataSource = typeof(ExaminationManagement.Functions.ConnectDatabase.Result);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.lollipopLabel1);
            this.groupbox1.Controls.Add(this.cbb_examination);
            this.groupbox1.Controls.Add(this.btn_view);
            this.groupbox1.Location = new System.Drawing.Point(0, 64);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(954, 123);
            this.groupbox1.TabIndex = 3;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Info";
            // 
            // rptExamResult
            // 
            reportDataSource1.Name = "examination";
            reportDataSource1.Value = this.TheExaminationBindingSource;
            reportDataSource2.Name = "result";
            reportDataSource2.Value = this.ResultBindingSource;
            this.rptExamResult.LocalReport.DataSources.Add(reportDataSource1);
            this.rptExamResult.LocalReport.DataSources.Add(reportDataSource2);
            this.rptExamResult.LocalReport.ReportEmbeddedResource = "ExaminationManagement.Forms.Report.rptExaminationResultReport.rdlc";
            this.rptExamResult.Location = new System.Drawing.Point(0, 187);
            this.rptExamResult.Name = "rptExamResult";
            this.rptExamResult.ServerReport.BearerToken = null;
            this.rptExamResult.Size = new System.Drawing.Size(954, 327);
            this.rptExamResult.TabIndex = 4;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.BGColor = "#508ef5";
            this.btn_view.FontColor = "#ffffff";
            this.btn_view.Location = new System.Drawing.Point(373, 39);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(90, 29);
            this.btn_view.TabIndex = 3;
            this.btn_view.Text = "View";
            // 
            // cbb_examination
            // 
            this.cbb_examination.FormattingEnabled = true;
            this.cbb_examination.ItemHeight = 23;
            this.cbb_examination.Location = new System.Drawing.Point(246, 39);
            this.cbb_examination.Name = "cbb_examination";
            this.cbb_examination.Size = new System.Drawing.Size(121, 29);
            this.cbb_examination.TabIndex = 4;
            this.cbb_examination.UseSelectable = true;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(43, 42);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(197, 26);
            this.lollipopLabel1.TabIndex = 5;
            this.lollipopLabel1.Text = "Choose Examination";
            // 
            // ExaminationResultReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 516);
            this.Controls.Add(this.rptExamResult);
            this.Controls.Add(this.groupbox1);
            this.MaximizeBox = false;
            this.Name = "ExaminationResultReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExaminationResultReport";
            this.Load += new System.EventHandler(this.ExaminationResultReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TheExaminationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptExamResult;
        private System.Windows.Forms.BindingSource TheExaminationBindingSource;
        private System.Windows.Forms.BindingSource ResultBindingSource;
        private LollipopButton btn_view;
        private LollipopLabel lollipopLabel1;
        private MetroFramework.Controls.MetroComboBox cbb_examination;
    }
}