namespace ExaminationManagement.Forms.Report
{
    partial class StudentListReport
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
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.rptStudentList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbb_examination = new MetroFramework.Controls.MetroComboBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.btn_view = new LollipopButton();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.lollipopLabel1);
            this.groupbox1.Controls.Add(this.cbb_examination);
            this.groupbox1.Controls.Add(this.btn_view);
            this.groupbox1.Location = new System.Drawing.Point(0, 63);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(800, 123);
            this.groupbox1.TabIndex = 4;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Info";
            // 
            // rptStudentList
            // 
            this.rptStudentList.LocalReport.ReportEmbeddedResource = "ExaminationManagement.Forms.Report.StudentListReport.rdlc";
            this.rptStudentList.Location = new System.Drawing.Point(0, 192);
            this.rptStudentList.Name = "rptStudentList";
            this.rptStudentList.ServerReport.BearerToken = null;
            this.rptStudentList.Size = new System.Drawing.Size(800, 327);
            this.rptStudentList.TabIndex = 5;
            // 
            // cbb_examination
            // 
            this.cbb_examination.FormattingEnabled = true;
            this.cbb_examination.ItemHeight = 23;
            this.cbb_examination.Location = new System.Drawing.Point(331, 51);
            this.cbb_examination.Name = "cbb_examination";
            this.cbb_examination.Size = new System.Drawing.Size(121, 29);
            this.cbb_examination.TabIndex = 3;
            this.cbb_examination.UseSelectable = true;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(128, 51);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(197, 26);
            this.lollipopLabel1.TabIndex = 4;
            this.lollipopLabel1.Text = "Choose Examination";
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.BGColor = "#508ef5";
            this.btn_view.FontColor = "#ffffff";
            this.btn_view.Location = new System.Drawing.Point(458, 51);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(106, 29);
            this.btn_view.TabIndex = 2;
            this.btn_view.Text = "Review";
            // 
            // StudentListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.rptStudentList);
            this.Controls.Add(this.groupbox1);
            this.MaximizeBox = false;
            this.Name = "StudentListReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentListReport";
            this.Load += new System.EventHandler(this.StudentListReport_Load);
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptStudentList;
        private MetroFramework.Controls.MetroComboBox cbb_examination;
        private LollipopButton btn_view;
        private LollipopLabel lollipopLabel1;
    }
}