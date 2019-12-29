namespace ExaminationManagement.Forms.Student
{
    partial class ExaminationControlPanel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_exam = new System.Windows.Forms.Panel();
            this.pnl_mainExam = new System.Windows.Forms.Panel();
            this.dgv_examInfo = new System.Windows.Forms.DataGridView();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.btn_mainExam = new System.Windows.Forms.Button();
            this.btn_testExam = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_exam = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_exam.SuspendLayout();
            this.pnl_mainExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 59);
            this.panel2.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(3, 4);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(114, 50);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_exam);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 547);
            this.panel1.TabIndex = 3;
            // 
            // pnl_exam
            // 
            this.pnl_exam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_exam.Controls.Add(this.pnl_mainExam);
            this.pnl_exam.Controls.Add(this.btn_mainExam);
            this.pnl_exam.Controls.Add(this.btn_testExam);
            this.pnl_exam.Location = new System.Drawing.Point(12, 86);
            this.pnl_exam.Name = "pnl_exam";
            this.pnl_exam.Size = new System.Drawing.Size(560, 355);
            this.pnl_exam.TabIndex = 3;
            this.pnl_exam.Visible = false;
            // 
            // pnl_mainExam
            // 
            this.pnl_mainExam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_mainExam.Controls.Add(this.dgv_examInfo);
            this.pnl_mainExam.Controls.Add(this.btn_enroll);
            this.pnl_mainExam.Location = new System.Drawing.Point(3, 76);
            this.pnl_mainExam.Name = "pnl_mainExam";
            this.pnl_mainExam.Size = new System.Drawing.Size(454, 240);
            this.pnl_mainExam.TabIndex = 4;
            this.pnl_mainExam.Visible = false;
            // 
            // dgv_examInfo
            // 
            this.dgv_examInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_examInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_examInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_examInfo.Location = new System.Drawing.Point(8, 3);
            this.dgv_examInfo.Name = "dgv_examInfo";
            this.dgv_examInfo.Size = new System.Drawing.Size(235, 160);
            this.dgv_examInfo.TabIndex = 1;
            // 
            // btn_enroll
            // 
            this.btn_enroll.Location = new System.Drawing.Point(313, 172);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(136, 63);
            this.btn_enroll.TabIndex = 0;
            this.btn_enroll.Text = "Enroll";
            this.btn_enroll.UseVisualStyleBackColor = true;
            // 
            // btn_mainExam
            // 
            this.btn_mainExam.Location = new System.Drawing.Point(12, 7);
            this.btn_mainExam.Name = "btn_mainExam";
            this.btn_mainExam.Size = new System.Drawing.Size(136, 63);
            this.btn_mainExam.TabIndex = 0;
            this.btn_mainExam.Text = "Main Exam";
            this.btn_mainExam.UseVisualStyleBackColor = true;
            // 
            // btn_testExam
            // 
            this.btn_testExam.Location = new System.Drawing.Point(154, 7);
            this.btn_testExam.Name = "btn_testExam";
            this.btn_testExam.Size = new System.Drawing.Size(136, 63);
            this.btn_testExam.TabIndex = 1;
            this.btn_testExam.Text = "Test Exam";
            this.btn_testExam.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_result);
            this.panel3.Controls.Add(this.btn_exam);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 80);
            this.panel3.TabIndex = 2;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(153, 6);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(136, 63);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "Result";
            this.btn_result.UseVisualStyleBackColor = true;
            // 
            // btn_exam
            // 
            this.btn_exam.Location = new System.Drawing.Point(11, 6);
            this.btn_exam.Name = "btn_exam";
            this.btn_exam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_exam.Size = new System.Drawing.Size(136, 63);
            this.btn_exam.TabIndex = 1;
            this.btn_exam.Text = "Your Examination";
            this.btn_exam.UseVisualStyleBackColor = true;
            // 
            // ExaminationControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Maven Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExaminationControlPanel";
            this.Text = "ExaminationControlPanel";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_exam.ResumeLayout(false);
            this.pnl_mainExam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_exam;
        private System.Windows.Forms.Panel pnl_exam;
        private System.Windows.Forms.Button btn_mainExam;
        private System.Windows.Forms.Button btn_testExam;
        private System.Windows.Forms.Panel pnl_mainExam;
        private System.Windows.Forms.Button btn_enroll;
        private System.Windows.Forms.DataGridView dgv_examInfo;
    }
}