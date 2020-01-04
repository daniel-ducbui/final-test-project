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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new LollipopFlatButton();
            this.pnl_exam = new System.Windows.Forms.Panel();
            this.dgv_data = new MetroFramework.Controls.MetroGrid();
            this.btn_control = new LollipopFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_result = new LollipopFlatButton();
            this.btn_testExam = new LollipopButton();
            this.btn_mainExam = new LollipopButton();
            this.panel2.SuspendLayout();
            this.pnl_exam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 45);
            this.panel2.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FontColor = "#ff271d";
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(105, 36);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            // 
            // pnl_exam
            // 
            this.pnl_exam.Controls.Add(this.dgv_data);
            this.pnl_exam.Controls.Add(this.btn_control);
            this.pnl_exam.Location = new System.Drawing.Point(0, 182);
            this.pnl_exam.Name = "pnl_exam";
            this.pnl_exam.Size = new System.Drawing.Size(1194, 419);
            this.pnl_exam.TabIndex = 3;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToResizeRows = false;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_data.Location = new System.Drawing.Point(0, 0);
            this.dgv_data.MultiSelect = false;
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_data.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(1194, 346);
            this.dgv_data.TabIndex = 4;
            // 
            // btn_control
            // 
            this.btn_control.BackColor = System.Drawing.Color.Transparent;
            this.btn_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_control.FontColor = "#508ef5";
            this.btn_control.Location = new System.Drawing.Point(0, 352);
            this.btn_control.Name = "btn_control";
            this.btn_control.Size = new System.Drawing.Size(1194, 67);
            this.btn_control.TabIndex = 2;
            this.btn_control.Text = "Enroll";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_result);
            this.panel3.Controls.Add(this.btn_testExam);
            this.panel3.Controls.Add(this.btn_mainExam);
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1194, 71);
            this.panel3.TabIndex = 2;
            // 
            // btn_result
            // 
            this.btn_result.BackColor = System.Drawing.Color.Transparent;
            this.btn_result.FontColor = "#00ff1f";
            this.btn_result.Location = new System.Drawing.Point(381, 3);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(183, 63);
            this.btn_result.TabIndex = 5;
            this.btn_result.Text = "Result";
            // 
            // btn_testExam
            // 
            this.btn_testExam.BackColor = System.Drawing.Color.Transparent;
            this.btn_testExam.BGColor = "#508ef5";
            this.btn_testExam.FontColor = "#ffffff";
            this.btn_testExam.Location = new System.Drawing.Point(192, 3);
            this.btn_testExam.Name = "btn_testExam";
            this.btn_testExam.Size = new System.Drawing.Size(183, 63);
            this.btn_testExam.TabIndex = 4;
            this.btn_testExam.Text = "Test Examination";
            // 
            // btn_mainExam
            // 
            this.btn_mainExam.BackColor = System.Drawing.Color.Transparent;
            this.btn_mainExam.BGColor = "#508ef5";
            this.btn_mainExam.FontColor = "#ffffff";
            this.btn_mainExam.Location = new System.Drawing.Point(3, 3);
            this.btn_mainExam.Name = "btn_mainExam";
            this.btn_mainExam.Size = new System.Drawing.Size(183, 63);
            this.btn_mainExam.TabIndex = 3;
            this.btn_mainExam.Text = "Main Examination";
            // 
            // ExaminationControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 602);
            this.Controls.Add(this.pnl_exam);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Maven Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ExaminationControlPanel";
            this.Text = "ExaminationControlPanel";
            this.panel2.ResumeLayout(false);
            this.pnl_exam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_exam;
        private LollipopButton btn_mainExam;
        private LollipopFlatButton btn_back;
        private LollipopFlatButton btn_result;
        private LollipopButton btn_testExam;
        private LollipopFlatButton btn_control;
        private MetroFramework.Controls.MetroGrid dgv_data;
    }
}