namespace ExaminationManagement.Forms.Report
{
    partial class Teacher_StudentResultReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rptStudentResult = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_view = new LollipopButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptStudentResult
            // 
            reportDataSource4.Name = "result";
            reportDataSource4.Value = this.ResultBindingSource;
            this.rptStudentResult.LocalReport.DataSources.Add(reportDataSource4);
            this.rptStudentResult.LocalReport.ReportEmbeddedResource = "ExaminationManagement.Forms.Report.rptTeacher_StudentResultReport.rdlc";
            this.rptStudentResult.Location = new System.Drawing.Point(0, 111);
            this.rptStudentResult.Name = "rptStudentResult";
            this.rptStudentResult.ServerReport.BearerToken = null;
            this.rptStudentResult.Size = new System.Drawing.Size(1103, 477);
            this.rptStudentResult.TabIndex = 6;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.BGColor = "#508ef5";
            this.btn_view.FontColor = "#ffffff";
            this.btn_view.Location = new System.Drawing.Point(955, 3);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(143, 37);
            this.btn_view.TabIndex = 7;
            this.btn_view.Text = "View";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_view);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 45);
            this.panel1.TabIndex = 8;
            // 
            // Teacher_StudentResultReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rptStudentResult);
            this.MaximizeBox = false;
            this.Name = "Teacher_StudentResultReport";
            this.Sizable = false;
            this.Text = "Student Result";
            this.Load += new System.EventHandler(this.Teacher_StudentResultReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rptStudentResult;
        private LollipopButton btn_view;
        private System.Windows.Forms.Panel panel1;
    }
}