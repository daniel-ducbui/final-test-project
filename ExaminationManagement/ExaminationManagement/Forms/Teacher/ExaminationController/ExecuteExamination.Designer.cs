namespace ExaminationManagement.Forms.Teacher.ExaminationController
{
    partial class ExecuteExamination
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
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.tb_time = new LollipopTextBox();
            this.cb_grade = new MetroFramework.Controls.MetroComboBox();
            this.cb_type = new MetroFramework.Controls.MetroComboBox();
            this.cb_examineeListID = new MetroFramework.Controls.MetroComboBox();
            this.cb_testListID = new MetroFramework.Controls.MetroComboBox();
            this.tb_examinationName = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel8 = new LollipopLabel();
            this.lollipopLabel7 = new LollipopLabel();
            this.lollipopLabel9 = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.lollipopLabel5 = new LollipopLabel();
            this.lollipopLabel4 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancel = new LollipopFlatButton();
            this.btn_save = new LollipopButton();
            this.btn_create = new LollipopButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtp_endDate);
            this.panel2.Controls.Add(this.dtp_startDate);
            this.panel2.Controls.Add(this.tb_time);
            this.panel2.Controls.Add(this.cb_grade);
            this.panel2.Controls.Add(this.cb_type);
            this.panel2.Controls.Add(this.cb_examineeListID);
            this.panel2.Controls.Add(this.cb_testListID);
            this.panel2.Controls.Add(this.tb_examinationName);
            this.panel2.Controls.Add(this.lollipopLabel3);
            this.panel2.Controls.Add(this.lollipopLabel8);
            this.panel2.Controls.Add(this.lollipopLabel7);
            this.panel2.Controls.Add(this.lollipopLabel9);
            this.panel2.Controls.Add(this.lollipopLabel6);
            this.panel2.Controls.Add(this.lollipopLabel5);
            this.panel2.Controls.Add(this.lollipopLabel4);
            this.panel2.Controls.Add(this.lollipopLabel2);
            this.panel2.Controls.Add(this.lollipopLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 310);
            this.panel2.TabIndex = 1;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endDate.Location = new System.Drawing.Point(211, 252);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_endDate.TabIndex = 8;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startDate.Location = new System.Drawing.Point(211, 220);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_startDate.TabIndex = 7;
            // 
            // tb_time
            // 
            this.tb_time.FocusedColor = "#508ef5";
            this.tb_time.FontColor = "#999999";
            this.tb_time.IsEnabled = true;
            this.tb_time.Location = new System.Drawing.Point(211, 190);
            this.tb_time.MaxLength = 32767;
            this.tb_time.Multiline = false;
            this.tb_time.Name = "tb_time";
            this.tb_time.ReadOnly = false;
            this.tb_time.Size = new System.Drawing.Size(121, 24);
            this.tb_time.TabIndex = 6;
            this.tb_time.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_time.UseSystemPasswordChar = false;
            // 
            // cb_grade
            // 
            this.cb_grade.FormattingEnabled = true;
            this.cb_grade.ItemHeight = 23;
            this.cb_grade.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cb_grade.Location = new System.Drawing.Point(211, 155);
            this.cb_grade.Name = "cb_grade";
            this.cb_grade.Size = new System.Drawing.Size(121, 29);
            this.cb_grade.TabIndex = 5;
            this.cb_grade.UseSelectable = true;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.ItemHeight = 23;
            this.cb_type.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_type.Location = new System.Drawing.Point(211, 120);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 29);
            this.cb_type.TabIndex = 4;
            this.cb_type.UseSelectable = true;
            // 
            // cb_examineeListID
            // 
            this.cb_examineeListID.FormattingEnabled = true;
            this.cb_examineeListID.ItemHeight = 23;
            this.cb_examineeListID.Items.AddRange(new object[] {
            "Default"});
            this.cb_examineeListID.Location = new System.Drawing.Point(211, 85);
            this.cb_examineeListID.Name = "cb_examineeListID";
            this.cb_examineeListID.Size = new System.Drawing.Size(121, 29);
            this.cb_examineeListID.TabIndex = 3;
            this.cb_examineeListID.UseSelectable = true;
            // 
            // cb_testListID
            // 
            this.cb_testListID.FormattingEnabled = true;
            this.cb_testListID.ItemHeight = 23;
            this.cb_testListID.Items.AddRange(new object[] {
            "Default"});
            this.cb_testListID.Location = new System.Drawing.Point(211, 50);
            this.cb_testListID.Name = "cb_testListID";
            this.cb_testListID.Size = new System.Drawing.Size(121, 29);
            this.cb_testListID.TabIndex = 2;
            this.cb_testListID.UseSelectable = true;
            // 
            // tb_examinationName
            // 
            this.tb_examinationName.FocusedColor = "#508ef5";
            this.tb_examinationName.FontColor = "#999999";
            this.tb_examinationName.IsEnabled = true;
            this.tb_examinationName.Location = new System.Drawing.Point(211, 20);
            this.tb_examinationName.MaxLength = 32767;
            this.tb_examinationName.Multiline = false;
            this.tb_examinationName.Name = "tb_examinationName";
            this.tb_examinationName.ReadOnly = false;
            this.tb_examinationName.Size = new System.Drawing.Size(329, 24);
            this.tb_examinationName.TabIndex = 1;
            this.tb_examinationName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_examinationName.UseSystemPasswordChar = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(12, 20);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(178, 24);
            this.lollipopLabel3.TabIndex = 0;
            this.lollipopLabel3.Text = "Examination Name";
            // 
            // lollipopLabel8
            // 
            this.lollipopLabel8.AutoSize = true;
            this.lollipopLabel8.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel8.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel8.Location = new System.Drawing.Point(12, 254);
            this.lollipopLabel8.Name = "lollipopLabel8";
            this.lollipopLabel8.Size = new System.Drawing.Size(90, 24);
            this.lollipopLabel8.TabIndex = 0;
            this.lollipopLabel8.Text = "End Date";
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(12, 222);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(100, 24);
            this.lollipopLabel7.TabIndex = 0;
            this.lollipopLabel7.Text = "Start Date";
            // 
            // lollipopLabel9
            // 
            this.lollipopLabel9.AutoSize = true;
            this.lollipopLabel9.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel9.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel9.Location = new System.Drawing.Point(338, 190);
            this.lollipopLabel9.Name = "lollipopLabel9";
            this.lollipopLabel9.Size = new System.Drawing.Size(80, 24);
            this.lollipopLabel9.TabIndex = 0;
            this.lollipopLabel9.Text = "minutes";
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(12, 190);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(53, 24);
            this.lollipopLabel6.TabIndex = 0;
            this.lollipopLabel6.Text = "Time";
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(12, 160);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(62, 24);
            this.lollipopLabel5.TabIndex = 0;
            this.lollipopLabel5.Text = "Grade";
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(12, 125);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(167, 24);
            this.lollipopLabel4.TabIndex = 0;
            this.lollipopLabel4.Text = "Examination Type";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 90);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(156, 24);
            this.lollipopLabel2.TabIndex = 0;
            this.lollipopLabel2.Text = "Examinee List ID";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(12, 55);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(106, 24);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Test List ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_cancel);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Controls.Add(this.btn_create);
            this.panel3.Location = new System.Drawing.Point(0, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 58);
            this.panel3.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FontColor = "#ed5245";
            this.btn_cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(175, 52);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BGColor = "#508ef5";
            this.btn_save.FontColor = "#ffffff";
            this.btn_save.Location = new System.Drawing.Point(184, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(175, 52);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.BGColor = "#508ef5";
            this.btn_create.FontColor = "#ffffff";
            this.btn_create.Location = new System.Drawing.Point(365, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(184, 52);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            // 
            // ExecuteExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 464);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "ExecuteExamination";
            this.Text = "ExecuteExamination";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel8;
        private LollipopLabel lollipopLabel7;
        private LollipopLabel lollipopLabel6;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel4;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroComboBox cb_type;
        private MetroFramework.Controls.MetroComboBox cb_examineeListID;
        private MetroFramework.Controls.MetroComboBox cb_testListID;
        private LollipopTextBox tb_examinationName;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private LollipopTextBox tb_time;
        private MetroFramework.Controls.MetroComboBox cb_grade;
        private LollipopLabel lollipopLabel9;
        private LollipopFlatButton btn_cancel;
        private LollipopButton btn_save;
        private LollipopButton btn_create;
    }
}