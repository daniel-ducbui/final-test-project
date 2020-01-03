namespace ExaminationManagement.Forms
{
    partial class TeacherControlPanel
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
            this.btn_questionManagement = new System.Windows.Forms.Button();
            this.btn_examManagement = new System.Windows.Forms.Button();
            this.btn_manageTheListOfContestants = new System.Windows.Forms.Button();
            this.btn_testList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_questionManagement
            // 
            this.btn_questionManagement.Location = new System.Drawing.Point(14, 14);
            this.btn_questionManagement.Margin = new System.Windows.Forms.Padding(5);
            this.btn_questionManagement.Name = "btn_questionManagement";
            this.btn_questionManagement.Size = new System.Drawing.Size(297, 109);
            this.btn_questionManagement.TabIndex = 0;
            this.btn_questionManagement.Text = "Question Management";
            this.btn_questionManagement.UseVisualStyleBackColor = true;
            // 
            // btn_examManagement
            // 
            this.btn_examManagement.Location = new System.Drawing.Point(330, 14);
            this.btn_examManagement.Margin = new System.Windows.Forms.Padding(5);
            this.btn_examManagement.Name = "btn_examManagement";
            this.btn_examManagement.Size = new System.Drawing.Size(297, 109);
            this.btn_examManagement.TabIndex = 1;
            this.btn_examManagement.Text = "Exam Management";
            this.btn_examManagement.UseVisualStyleBackColor = true;
            // 
            // btn_manageTheListOfContestants
            // 
            this.btn_manageTheListOfContestants.Location = new System.Drawing.Point(650, 14);
            this.btn_manageTheListOfContestants.Margin = new System.Windows.Forms.Padding(5);
            this.btn_manageTheListOfContestants.Name = "btn_manageTheListOfContestants";
            this.btn_manageTheListOfContestants.Size = new System.Drawing.Size(297, 109);
            this.btn_manageTheListOfContestants.TabIndex = 2;
            this.btn_manageTheListOfContestants.Text = "Manage The List Of Contestants";
            this.btn_manageTheListOfContestants.UseVisualStyleBackColor = true;
            // 
            // btn_testList
            // 
            this.btn_testList.Location = new System.Drawing.Point(967, 14);
            this.btn_testList.Margin = new System.Windows.Forms.Padding(5);
            this.btn_testList.Name = "btn_testList";
            this.btn_testList.Size = new System.Drawing.Size(297, 109);
            this.btn_testList.TabIndex = 3;
            this.btn_testList.Text = "Test List";
            this.btn_testList.UseVisualStyleBackColor = true;
            // 
            // TeacherControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 540);
            this.Controls.Add(this.btn_testList);
            this.Controls.Add(this.btn_manageTheListOfContestants);
            this.Controls.Add(this.btn_examManagement);
            this.Controls.Add(this.btn_questionManagement);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TeacherControlPanel";
            this.Text = "TeacherControlPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_questionManagement;
        private System.Windows.Forms.Button btn_examManagement;
        private System.Windows.Forms.Button btn_manageTheListOfContestants;
        private System.Windows.Forms.Button btn_testList;
    }
}