namespace ExaminationManagement.Forms.Teacher
{
    partial class ExaminationManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_data = new MetroFramework.Controls.MetroGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_detele = new LollipopButton();
            this.btn_editExamination = new LollipopButton();
            this.btn_createExamineeList = new LollipopButton();
            this.btn_load = new LollipopButton();
            this.btn_createTest = new LollipopButton();
            this.btn_createExamination = new LollipopButton();
            this.btn_back = new LollipopFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_data);
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 631);
            this.panel2.TabIndex = 1;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_data.Location = new System.Drawing.Point(3, 3);
            this.dgv_data.MultiSelect = false;
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(1142, 625);
            this.dgv_data.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_detele);
            this.panel4.Controls.Add(this.btn_editExamination);
            this.panel4.Controls.Add(this.btn_createExamineeList);
            this.panel4.Controls.Add(this.btn_load);
            this.panel4.Controls.Add(this.btn_createTest);
            this.panel4.Controls.Add(this.btn_createExamination);
            this.panel4.Location = new System.Drawing.Point(1154, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 631);
            this.panel4.TabIndex = 3;
            // 
            // btn_detele
            // 
            this.btn_detele.BackColor = System.Drawing.Color.Transparent;
            this.btn_detele.BGColor = "#ed5245";
            this.btn_detele.FontColor = "#ffffff";
            this.btn_detele.Location = new System.Drawing.Point(3, 283);
            this.btn_detele.Name = "btn_detele";
            this.btn_detele.Size = new System.Drawing.Size(185, 50);
            this.btn_detele.TabIndex = 6;
            this.btn_detele.Text = "Delete";
            // 
            // btn_editExamination
            // 
            this.btn_editExamination.BackColor = System.Drawing.Color.Transparent;
            this.btn_editExamination.BGColor = "#508ef5";
            this.btn_editExamination.FontColor = "#ffffff";
            this.btn_editExamination.Location = new System.Drawing.Point(3, 59);
            this.btn_editExamination.Name = "btn_editExamination";
            this.btn_editExamination.Size = new System.Drawing.Size(185, 50);
            this.btn_editExamination.TabIndex = 5;
            this.btn_editExamination.Text = "Edit Examination Information";
            // 
            // btn_createExamineeList
            // 
            this.btn_createExamineeList.BackColor = System.Drawing.Color.Transparent;
            this.btn_createExamineeList.BGColor = "#508ef5";
            this.btn_createExamineeList.FontColor = "#ffffff";
            this.btn_createExamineeList.Location = new System.Drawing.Point(3, 171);
            this.btn_createExamineeList.Name = "btn_createExamineeList";
            this.btn_createExamineeList.Size = new System.Drawing.Size(185, 50);
            this.btn_createExamineeList.TabIndex = 4;
            this.btn_createExamineeList.Text = "Create Examinee List";
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.BGColor = "#508ef5";
            this.btn_load.FontColor = "#ffffff";
            this.btn_load.Location = new System.Drawing.Point(3, 227);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(185, 50);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Reload";
            // 
            // btn_createTest
            // 
            this.btn_createTest.BackColor = System.Drawing.Color.Transparent;
            this.btn_createTest.BGColor = "#508ef5";
            this.btn_createTest.FontColor = "#ffffff";
            this.btn_createTest.Location = new System.Drawing.Point(3, 115);
            this.btn_createTest.Name = "btn_createTest";
            this.btn_createTest.Size = new System.Drawing.Size(185, 50);
            this.btn_createTest.TabIndex = 2;
            this.btn_createTest.Text = "Tests Manager";
            // 
            // btn_createExamination
            // 
            this.btn_createExamination.BackColor = System.Drawing.Color.Transparent;
            this.btn_createExamination.BGColor = "#508ef5";
            this.btn_createExamination.FontColor = "#ffffff";
            this.btn_createExamination.Location = new System.Drawing.Point(3, 3);
            this.btn_createExamination.Name = "btn_createExamination";
            this.btn_createExamination.Size = new System.Drawing.Size(185, 50);
            this.btn_createExamination.TabIndex = 0;
            this.btn_createExamination.Text = "Create Examination";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FontColor = "#ed5245";
            this.btn_back.Location = new System.Drawing.Point(3, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(105, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            // 
            // ExaminationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 758);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExaminationManager";
            this.Sizable = false;
            this.Text = "Examination Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LollipopFlatButton btn_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroGrid dgv_data;
        private LollipopButton btn_createExamination;
        private LollipopButton btn_createTest;
        private LollipopButton btn_load;
        private LollipopButton btn_createExamineeList;
        private LollipopButton btn_editExamination;
        private LollipopButton btn_detele;
    }
}