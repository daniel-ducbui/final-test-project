namespace ExaminationManagement.Forms.Teacher
{
    partial class ManagingQuestionsInTheExamControlPanel
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_examInformation = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_createTest = new System.Windows.Forms.Button();
            this.txt_examName = new System.Windows.Forms.TextBox();
            this.txt_examPaperCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_questionSection = new System.Windows.Forms.DataGridView();
            this.btn_addTheQuestion = new System.Windows.Forms.Button();
            this.btn_deleteTheQuestion = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_deleteTheTest = new System.Windows.Forms.Button();
            this.dgv_listOfAllTheQuestion = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examInformation)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionSection)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listOfAllTheQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1491, 40);
            this.panel1.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1491, 487);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing Section";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_examInformation);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(741, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 455);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "The Test Section";
            // 
            // dgv_examInformation
            // 
            this.dgv_examInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_examInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_examInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_examInformation.Location = new System.Drawing.Point(3, 150);
            this.dgv_examInformation.Name = "dgv_examInformation";
            this.dgv_examInformation.RowHeadersWidth = 51;
            this.dgv_examInformation.RowTemplate.Height = 24;
            this.dgv_examInformation.Size = new System.Drawing.Size(739, 302);
            this.dgv_examInformation.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_createTest);
            this.groupBox4.Controls.Add(this.txt_examName);
            this.groupBox4.Controls.Add(this.txt_examPaperCode);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(739, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Information";
            // 
            // btn_createTest
            // 
            this.btn_createTest.Location = new System.Drawing.Point(582, 21);
            this.btn_createTest.Name = "btn_createTest";
            this.btn_createTest.Size = new System.Drawing.Size(151, 72);
            this.btn_createTest.TabIndex = 4;
            this.btn_createTest.Text = "Create test";
            this.btn_createTest.UseVisualStyleBackColor = true;
            // 
            // txt_examName
            // 
            this.txt_examName.Location = new System.Drawing.Point(224, 65);
            this.txt_examName.Name = "txt_examName";
            this.txt_examName.Size = new System.Drawing.Size(352, 33);
            this.txt_examName.TabIndex = 3;
            // 
            // txt_examPaperCode
            // 
            this.txt_examPaperCode.Location = new System.Drawing.Point(224, 26);
            this.txt_examPaperCode.Name = "txt_examPaperCode";
            this.txt_examPaperCode.Size = new System.Drawing.Size(352, 33);
            this.txt_examPaperCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam paper code";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_deleteTheQuestion);
            this.panel2.Controls.Add(this.btn_addTheQuestion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(666, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 455);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_questionSection);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 455);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question Section";
            // 
            // dgv_questionSection
            // 
            this.dgv_questionSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_questionSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questionSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_questionSection.Location = new System.Drawing.Point(3, 150);
            this.dgv_questionSection.Name = "dgv_questionSection";
            this.dgv_questionSection.RowHeadersWidth = 51;
            this.dgv_questionSection.RowTemplate.Height = 24;
            this.dgv_questionSection.Size = new System.Drawing.Size(657, 302);
            this.dgv_questionSection.TabIndex = 0;
            // 
            // btn_addTheQuestion
            // 
            this.btn_addTheQuestion.Location = new System.Drawing.Point(0, 232);
            this.btn_addTheQuestion.Name = "btn_addTheQuestion";
            this.btn_addTheQuestion.Size = new System.Drawing.Size(75, 64);
            this.btn_addTheQuestion.TabIndex = 0;
            this.btn_addTheQuestion.Text = ">";
            this.btn_addTheQuestion.UseVisualStyleBackColor = true;
            // 
            // btn_deleteTheQuestion
            // 
            this.btn_deleteTheQuestion.Location = new System.Drawing.Point(0, 355);
            this.btn_deleteTheQuestion.Name = "btn_deleteTheQuestion";
            this.btn_deleteTheQuestion.Size = new System.Drawing.Size(75, 64);
            this.btn_deleteTheQuestion.TabIndex = 1;
            this.btn_deleteTheQuestion.Text = "<";
            this.btn_deleteTheQuestion.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_listOfAllTheQuestion);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 527);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1491, 246);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List of all the questions";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_deleteTheTest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 773);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1491, 52);
            this.panel3.TabIndex = 6;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_update.Location = new System.Drawing.Point(1037, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(227, 52);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_deleteTheTest
            // 
            this.btn_deleteTheTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_deleteTheTest.Location = new System.Drawing.Point(1264, 0);
            this.btn_deleteTheTest.Name = "btn_deleteTheTest";
            this.btn_deleteTheTest.Size = new System.Drawing.Size(227, 52);
            this.btn_deleteTheTest.TabIndex = 0;
            this.btn_deleteTheTest.Text = "Delete the test";
            this.btn_deleteTheTest.UseVisualStyleBackColor = true;
            // 
            // dgv_listOfAllTheQuestion
            // 
            this.dgv_listOfAllTheQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listOfAllTheQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listOfAllTheQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listOfAllTheQuestion.Location = new System.Drawing.Point(3, 29);
            this.dgv_listOfAllTheQuestion.Name = "dgv_listOfAllTheQuestion";
            this.dgv_listOfAllTheQuestion.RowHeadersWidth = 51;
            this.dgv_listOfAllTheQuestion.RowTemplate.Height = 24;
            this.dgv_listOfAllTheQuestion.Size = new System.Drawing.Size(1485, 214);
            this.dgv_listOfAllTheQuestion.TabIndex = 0;
            // 
            // ExamManagementControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 830);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExamManagementControlPanel";
            this.Text = "ExamManagementControlPanel";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examInformation)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionSection)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listOfAllTheQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_questionSection;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_examInformation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_createTest;
        private System.Windows.Forms.TextBox txt_examName;
        private System.Windows.Forms.TextBox txt_examPaperCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_deleteTheQuestion;
        private System.Windows.Forms.Button btn_addTheQuestion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_listOfAllTheQuestion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_deleteTheTest;
    }
}