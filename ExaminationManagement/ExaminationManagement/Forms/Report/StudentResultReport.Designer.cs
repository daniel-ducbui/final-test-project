namespace ExaminationManagement.Forms.Report
{
    partial class StudentResultReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpv_result = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_back = new LollipopFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 44);
            this.panel1.TabIndex = 0;
            // 
            // rpv_result
            // 
            this.rpv_result.Location = new System.Drawing.Point(0, 114);
            this.rpv_result.Name = "rpv_result";
            this.rpv_result.ServerReport.BearerToken = null;
            this.rpv_result.Size = new System.Drawing.Size(640, 512);
            this.rpv_result.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FontColor = "#ff271d";
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 38);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            // 
            // StudentResultReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 638);
            this.Controls.Add(this.rpv_result);
            this.Controls.Add(this.panel1);
            this.Name = "StudentResultReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.StudentResultReport_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LollipopFlatButton btn_back;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_result;
    }
}