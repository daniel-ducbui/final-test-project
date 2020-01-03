namespace ExaminationManagement.Forms.Teacher
{
    partial class TestListControlPanel
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_listOfAllExamQuestions = new System.Windows.Forms.DataGridView();
            this.dgv_allTheTest = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addTheTest = new System.Windows.Forms.Button();
            this.btn_createTheTest = new System.Windows.Forms.Button();
            this.txt_testName = new System.Windows.Forms.TextBox();
            this.txt_testID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_deleteTheTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_partOfTheExam = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listOfAllExamQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allTheTest)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partOfTheExam)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.Location = new System.Drawing.Point(1265, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(227, 52);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete the test";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 773);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1492, 52);
            this.panel3.TabIndex = 10;
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_update.Location = new System.Drawing.Point(1038, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(227, 52);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_listOfAllExamQuestions);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 527);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1492, 246);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List of all exam questions";
            // 
            // dgv_listOfAllExamQuestions
            // 
            this.dgv_listOfAllExamQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listOfAllExamQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listOfAllExamQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listOfAllExamQuestions.Location = new System.Drawing.Point(3, 29);
            this.dgv_listOfAllExamQuestions.Name = "dgv_listOfAllExamQuestions";
            this.dgv_listOfAllExamQuestions.RowHeadersWidth = 51;
            this.dgv_listOfAllExamQuestions.RowTemplate.Height = 24;
            this.dgv_listOfAllExamQuestions.Size = new System.Drawing.Size(1486, 214);
            this.dgv_listOfAllExamQuestions.TabIndex = 0;
            // 
            // dgv_allTheTest
            // 
            this.dgv_allTheTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_allTheTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allTheTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_allTheTest.Location = new System.Drawing.Point(3, 150);
            this.dgv_allTheTest.Name = "dgv_allTheTest";
            this.dgv_allTheTest.RowHeadersWidth = 51;
            this.dgv_allTheTest.RowTemplate.Height = 24;
            this.dgv_allTheTest.Size = new System.Drawing.Size(657, 302);
            this.dgv_allTheTest.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_allTheTest);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 455);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All the test";
            // 
            // btn_addTheTest
            // 
            this.btn_addTheTest.Location = new System.Drawing.Point(0, 232);
            this.btn_addTheTest.Name = "btn_addTheTest";
            this.btn_addTheTest.Size = new System.Drawing.Size(75, 64);
            this.btn_addTheTest.TabIndex = 0;
            this.btn_addTheTest.Text = ">";
            this.btn_addTheTest.UseVisualStyleBackColor = true;
            // 
            // btn_createTheTest
            // 
            this.btn_createTheTest.Location = new System.Drawing.Point(582, 21);
            this.btn_createTheTest.Name = "btn_createTheTest";
            this.btn_createTheTest.Size = new System.Drawing.Size(151, 72);
            this.btn_createTheTest.TabIndex = 4;
            this.btn_createTheTest.Text = "Create the test";
            this.btn_createTheTest.UseVisualStyleBackColor = true;
            // 
            // txt_testName
            // 
            this.txt_testName.Location = new System.Drawing.Point(224, 65);
            this.txt_testName.Name = "txt_testName";
            this.txt_testName.Size = new System.Drawing.Size(352, 33);
            this.txt_testName.TabIndex = 3;
            // 
            // txt_testID
            // 
            this.txt_testID.Location = new System.Drawing.Point(224, 26);
            this.txt_testID.Name = "txt_testID";
            this.txt_testID.Size = new System.Drawing.Size(352, 33);
            this.txt_testID.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_deleteTheTest);
            this.panel2.Controls.Add(this.btn_addTheTest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(666, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 455);
            this.panel2.TabIndex = 1;
            // 
            // btn_deleteTheTest
            // 
            this.btn_deleteTheTest.Location = new System.Drawing.Point(0, 350);
            this.btn_deleteTheTest.Name = "btn_deleteTheTest";
            this.btn_deleteTheTest.Size = new System.Drawing.Size(75, 64);
            this.btn_deleteTheTest.TabIndex = 1;
            this.btn_deleteTheTest.Text = "<";
            this.btn_deleteTheTest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TestName";
            // 
            // dgv_partOfTheExam
            // 
            this.dgv_partOfTheExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_partOfTheExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_partOfTheExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_partOfTheExam.Location = new System.Drawing.Point(3, 150);
            this.dgv_partOfTheExam.Name = "dgv_partOfTheExam";
            this.dgv_partOfTheExam.RowHeadersWidth = 51;
            this.dgv_partOfTheExam.RowTemplate.Height = 24;
            this.dgv_partOfTheExam.Size = new System.Drawing.Size(739, 302);
            this.dgv_partOfTheExam.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_createTheTest);
            this.groupBox4.Controls.Add(this.txt_testName);
            this.groupBox4.Controls.Add(this.txt_testID);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(739, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam questions information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TestID ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_partOfTheExam);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(741, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 455);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Part Of The Exam";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1492, 487);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing Section";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 40);
            this.panel1.TabIndex = 7;
            // 
            // TestListControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 831);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TestListControlPanel";
            this.Text = "TestListControlPanel";
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listOfAllExamQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allTheTest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partOfTheExam)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_listOfAllExamQuestions;
        private System.Windows.Forms.DataGridView dgv_allTheTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addTheTest;
        private System.Windows.Forms.Button btn_createTheTest;
        private System.Windows.Forms.TextBox txt_testName;
        private System.Windows.Forms.TextBox txt_testID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_partOfTheExam;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deleteTheTest;
    }
}