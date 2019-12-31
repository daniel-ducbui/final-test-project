namespace ExaminationManagement.Forms.Teacher
{
    partial class ManageTheListOfContestantsControlPanel
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
            this.btn_deleteTheTest = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_listOfContestants = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_allOfStudents = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_createList = new System.Windows.Forms.Button();
            this.txt_listName = new System.Windows.Forms.TextBox();
            this.txt_listingCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deleteStudent = new System.Windows.Forms.Button();
            this.btn_addStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_partListCandidates = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listOfContestants)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allOfStudents)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partListCandidates)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_deleteTheTest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 773);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1491, 52);
            this.panel3.TabIndex = 10;
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
            // dgv_listOfContestants
            // 
            this.dgv_listOfContestants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listOfContestants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listOfContestants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listOfContestants.Location = new System.Drawing.Point(3, 29);
            this.dgv_listOfContestants.Name = "dgv_listOfContestants";
            this.dgv_listOfContestants.RowHeadersWidth = 51;
            this.dgv_listOfContestants.RowTemplate.Height = 24;
            this.dgv_listOfContestants.Size = new System.Drawing.Size(1485, 214);
            this.dgv_listOfContestants.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_listOfContestants);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 527);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1491, 246);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "List of contestants";
            // 
            // dgv_allOfStudents
            // 
            this.dgv_allOfStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_allOfStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allOfStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_allOfStudents.Location = new System.Drawing.Point(3, 150);
            this.dgv_allOfStudents.Name = "dgv_allOfStudents";
            this.dgv_allOfStudents.RowHeadersWidth = 51;
            this.dgv_allOfStudents.RowTemplate.Height = 24;
            this.dgv_allOfStudents.Size = new System.Drawing.Size(657, 302);
            this.dgv_allOfStudents.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_allOfStudents);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 455);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All of students";
            // 
            // btn_createList
            // 
            this.btn_createList.Location = new System.Drawing.Point(582, 21);
            this.btn_createList.Name = "btn_createList";
            this.btn_createList.Size = new System.Drawing.Size(151, 72);
            this.btn_createList.TabIndex = 4;
            this.btn_createList.Text = "Create List";
            this.btn_createList.UseVisualStyleBackColor = true;
            // 
            // txt_listName
            // 
            this.txt_listName.Location = new System.Drawing.Point(224, 65);
            this.txt_listName.Name = "txt_listName";
            this.txt_listName.Size = new System.Drawing.Size(352, 33);
            this.txt_listName.TabIndex = 3;
            // 
            // txt_listingCode
            // 
            this.txt_listingCode.Location = new System.Drawing.Point(224, 26);
            this.txt_listingCode.Name = "txt_listingCode";
            this.txt_listingCode.Size = new System.Drawing.Size(352, 33);
            this.txt_listingCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "List Name";
            // 
            // btn_deleteStudent
            // 
            this.btn_deleteStudent.Location = new System.Drawing.Point(0, 355);
            this.btn_deleteStudent.Name = "btn_deleteStudent";
            this.btn_deleteStudent.Size = new System.Drawing.Size(75, 64);
            this.btn_deleteStudent.TabIndex = 1;
            this.btn_deleteStudent.Text = "<";
            this.btn_deleteStudent.UseVisualStyleBackColor = true;
            // 
            // btn_addStudent
            // 
            this.btn_addStudent.Location = new System.Drawing.Point(0, 232);
            this.btn_addStudent.Name = "btn_addStudent";
            this.btn_addStudent.Size = new System.Drawing.Size(75, 64);
            this.btn_addStudent.TabIndex = 0;
            this.btn_addStudent.Text = ">";
            this.btn_addStudent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listing Code";
            // 
            // dgv_partListCandidates
            // 
            this.dgv_partListCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_partListCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_partListCandidates.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_partListCandidates.Location = new System.Drawing.Point(3, 150);
            this.dgv_partListCandidates.Name = "dgv_partListCandidates";
            this.dgv_partListCandidates.RowHeadersWidth = 51;
            this.dgv_partListCandidates.RowTemplate.Height = 24;
            this.dgv_partListCandidates.Size = new System.Drawing.Size(739, 302);
            this.dgv_partListCandidates.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_createList);
            this.groupBox4.Controls.Add(this.txt_listName);
            this.groupBox4.Controls.Add(this.txt_listingCode);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(739, 115);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listing Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_partListCandidates);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(741, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 455);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Part List Candidates";
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
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editing section";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_deleteStudent);
            this.panel2.Controls.Add(this.btn_addStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(666, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 455);
            this.panel2.TabIndex = 1;
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
            this.panel1.Size = new System.Drawing.Size(1491, 40);
            this.panel1.TabIndex = 7;
            // 
            // ManageTheListOfContestantsControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 849);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageTheListOfContestantsControlPanel";
            this.Text = "ManageTheListOfContestantsControlPanel";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listOfContestants)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allOfStudents)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_partListCandidates)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteTheTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_listOfContestants;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgv_allOfStudents;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_createList;
        private System.Windows.Forms.TextBox txt_listName;
        private System.Windows.Forms.TextBox txt_listingCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deleteStudent;
        private System.Windows.Forms.Button btn_addStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_partListCandidates;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel panel1;
    }
}