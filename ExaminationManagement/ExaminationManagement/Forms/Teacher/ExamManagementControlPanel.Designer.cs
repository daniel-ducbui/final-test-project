namespace ExaminationManagement.Forms.Teacher
{
    partial class ExamManagementControlPanel
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
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_createExam = new System.Windows.Forms.Button();
            this.mtb_startDay = new System.Windows.Forms.MaskedTextBox();
            this.mtb_endDay = new System.Windows.Forms.MaskedTextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_examName = new System.Windows.Forms.TextBox();
            this.ccb_chooseGrade = new System.Windows.Forms.ComboBox();
            this.ccb_chooseTheTestSet = new System.Windows.Forms.ComboBox();
            this.ccb_selectTheExamList = new System.Windows.Forms.ComboBox();
            this.ccb_kindOfExam = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_allExams = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_seeTheListOfExaminee = new System.Windows.Forms.Button();
            this.btn_seeTheResult = new System.Windows.Forms.Button();
            this.btn_createExamList = new System.Windows.Forms.Button();
            this.btn_createTheExamSet = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_deleteTheExam = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allExams)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 40);
            this.panel1.TabIndex = 8;
            // 
            // btn_back
            // 
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(124, 40);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_createTheExamSet);
            this.groupBox1.Controls.Add(this.btn_createExamList);
            this.groupBox1.Controls.Add(this.btn_createExam);
            this.groupBox1.Controls.Add(this.mtb_startDay);
            this.groupBox1.Controls.Add(this.mtb_endDay);
            this.groupBox1.Controls.Add(this.txt_time);
            this.groupBox1.Controls.Add(this.txt_examName);
            this.groupBox1.Controls.Add(this.ccb_chooseGrade);
            this.groupBox1.Controls.Add(this.ccb_chooseTheTestSet);
            this.groupBox1.Controls.Add(this.ccb_selectTheExamList);
            this.groupBox1.Controls.Add(this.ccb_kindOfExam);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 353);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam management";
            // 
            // btn_createExam
            // 
            this.btn_createExam.Location = new System.Drawing.Point(637, 177);
            this.btn_createExam.Name = "btn_createExam";
            this.btn_createExam.Size = new System.Drawing.Size(224, 77);
            this.btn_createExam.TabIndex = 28;
            this.btn_createExam.Text = "Create exam";
            this.btn_createExam.UseVisualStyleBackColor = true;
            // 
            // mtb_startDay
            // 
            this.mtb_startDay.Location = new System.Drawing.Point(217, 230);
            this.mtb_startDay.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_startDay.Mask = "00/00/0000";
            this.mtb_startDay.Name = "mtb_startDay";
            this.mtb_startDay.Size = new System.Drawing.Size(412, 33);
            this.mtb_startDay.TabIndex = 27;
            this.mtb_startDay.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_endDay
            // 
            this.mtb_endDay.Location = new System.Drawing.Point(218, 271);
            this.mtb_endDay.Margin = new System.Windows.Forms.Padding(4);
            this.mtb_endDay.Mask = "00/00/0000";
            this.mtb_endDay.Name = "mtb_endDay";
            this.mtb_endDay.Size = new System.Drawing.Size(411, 33);
            this.mtb_endDay.TabIndex = 27;
            this.mtb_endDay.ValidatingType = typeof(System.DateTime);
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(218, 311);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(323, 33);
            this.txt_time.TabIndex = 26;
            // 
            // txt_examName
            // 
            this.txt_examName.Location = new System.Drawing.Point(218, 32);
            this.txt_examName.Name = "txt_examName";
            this.txt_examName.Size = new System.Drawing.Size(411, 33);
            this.txt_examName.TabIndex = 25;
            // 
            // ccb_chooseGrade
            // 
            this.ccb_chooseGrade.FormattingEnabled = true;
            this.ccb_chooseGrade.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.ccb_chooseGrade.Location = new System.Drawing.Point(217, 190);
            this.ccb_chooseGrade.Name = "ccb_chooseGrade";
            this.ccb_chooseGrade.Size = new System.Drawing.Size(412, 33);
            this.ccb_chooseGrade.TabIndex = 24;
            // 
            // ccb_chooseTheTestSet
            // 
            this.ccb_chooseTheTestSet.FormattingEnabled = true;
            this.ccb_chooseTheTestSet.Location = new System.Drawing.Point(218, 151);
            this.ccb_chooseTheTestSet.Name = "ccb_chooseTheTestSet";
            this.ccb_chooseTheTestSet.Size = new System.Drawing.Size(412, 33);
            this.ccb_chooseTheTestSet.TabIndex = 24;
            // 
            // ccb_selectTheExamList
            // 
            this.ccb_selectTheExamList.FormattingEnabled = true;
            this.ccb_selectTheExamList.Location = new System.Drawing.Point(218, 112);
            this.ccb_selectTheExamList.Name = "ccb_selectTheExamList";
            this.ccb_selectTheExamList.Size = new System.Drawing.Size(412, 33);
            this.ccb_selectTheExamList.TabIndex = 24;
            // 
            // ccb_kindOfExam
            // 
            this.ccb_kindOfExam.FormattingEnabled = true;
            this.ccb_kindOfExam.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ccb_kindOfExam.Location = new System.Drawing.Point(217, 73);
            this.ccb_kindOfExam.Name = "ccb_kindOfExam";
            this.ccb_kindOfExam.Size = new System.Drawing.Size(412, 33);
            this.ccb_kindOfExam.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(637, 35);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(224, 129);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kind of exam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "2 : Mock exam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "3 : Review exam";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "1 : Official exam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "minute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "End date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Start day";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kind of exam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Choose the test set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select the exam list";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_allExams);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1091, 306);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All exams";
            // 
            // dgv_allExams
            // 
            this.dgv_allExams.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_allExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_allExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_allExams.Location = new System.Drawing.Point(3, 29);
            this.dgv_allExams.Name = "dgv_allExams";
            this.dgv_allExams.RowHeadersWidth = 51;
            this.dgv_allExams.RowTemplate.Height = 24;
            this.dgv_allExams.Size = new System.Drawing.Size(1085, 274);
            this.dgv_allExams.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_deleteTheExam);
            this.panel3.Controls.Add(this.btn_seeTheListOfExaminee);
            this.panel3.Controls.Add(this.btn_seeTheResult);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 699);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 52);
            this.panel3.TabIndex = 11;
            // 
            // btn_seeTheListOfExaminee
            // 
            this.btn_seeTheListOfExaminee.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_seeTheListOfExaminee.Location = new System.Drawing.Point(596, 0);
            this.btn_seeTheListOfExaminee.Name = "btn_seeTheListOfExaminee";
            this.btn_seeTheListOfExaminee.Size = new System.Drawing.Size(268, 52);
            this.btn_seeTheListOfExaminee.TabIndex = 1;
            this.btn_seeTheListOfExaminee.Text = "See the list of examinee";
            this.btn_seeTheListOfExaminee.UseVisualStyleBackColor = true;
            // 
            // btn_seeTheResult
            // 
            this.btn_seeTheResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_seeTheResult.Location = new System.Drawing.Point(864, 0);
            this.btn_seeTheResult.Name = "btn_seeTheResult";
            this.btn_seeTheResult.Size = new System.Drawing.Size(227, 52);
            this.btn_seeTheResult.TabIndex = 0;
            this.btn_seeTheResult.Text = "See the result";
            this.btn_seeTheResult.UseVisualStyleBackColor = true;
            // 
            // btn_createExamList
            // 
            this.btn_createExamList.Location = new System.Drawing.Point(876, 50);
            this.btn_createExamList.Name = "btn_createExamList";
            this.btn_createExamList.Size = new System.Drawing.Size(209, 77);
            this.btn_createExamList.TabIndex = 29;
            this.btn_createExamList.Text = "Create exam list";
            this.btn_createExamList.UseVisualStyleBackColor = true;
            // 
            // btn_createTheExamSet
            // 
            this.btn_createTheExamSet.Location = new System.Drawing.Point(876, 138);
            this.btn_createTheExamSet.Name = "btn_createTheExamSet";
            this.btn_createTheExamSet.Size = new System.Drawing.Size(209, 77);
            this.btn_createTheExamSet.TabIndex = 30;
            this.btn_createTheExamSet.Text = "Create the exam set";
            this.btn_createTheExamSet.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_update.Location = new System.Drawing.Point(142, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(227, 52);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_deleteTheExam
            // 
            this.btn_deleteTheExam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_deleteTheExam.Location = new System.Drawing.Point(369, 0);
            this.btn_deleteTheExam.Name = "btn_deleteTheExam";
            this.btn_deleteTheExam.Size = new System.Drawing.Size(227, 52);
            this.btn_deleteTheExam.TabIndex = 2;
            this.btn_deleteTheExam.Text = "Delete the exam";
            this.btn_deleteTheExam.UseVisualStyleBackColor = true;
            // 
            // ExamManagementControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExamManagementControlPanel";
            this.Text = "ExamManagementControlPanel";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allExams)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_createExam;
        private System.Windows.Forms.MaskedTextBox mtb_startDay;
        private System.Windows.Forms.MaskedTextBox mtb_endDay;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.TextBox txt_examName;
        private System.Windows.Forms.ComboBox ccb_chooseGrade;
        private System.Windows.Forms.ComboBox ccb_chooseTheTestSet;
        private System.Windows.Forms.ComboBox ccb_selectTheExamList;
        private System.Windows.Forms.ComboBox ccb_kindOfExam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_allExams;
        private System.Windows.Forms.Button btn_createTheExamSet;
        private System.Windows.Forms.Button btn_createExamList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_seeTheListOfExaminee;
        private System.Windows.Forms.Button btn_seeTheResult;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_deleteTheExam;
    }
}