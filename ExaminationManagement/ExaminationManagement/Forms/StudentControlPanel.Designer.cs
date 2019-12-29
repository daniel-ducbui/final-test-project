namespace ExaminationManagement.Forms
{
    partial class StudentControlPanel
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
            this.btn_question = new System.Windows.Forms.Button();
            this.btn_exam = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_question);
            this.panel1.Controls.Add(this.btn_exam);
            this.panel1.Controls.Add(this.btn_profile);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 85);
            this.panel1.TabIndex = 0;
            // 
            // btn_question
            // 
            this.btn_question.Font = new System.Drawing.Font("Maven Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_question.Location = new System.Drawing.Point(317, 3);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(151, 78);
            this.btn_question.TabIndex = 0;
            this.btn_question.Text = "Question";
            this.btn_question.UseVisualStyleBackColor = true;
            // 
            // btn_exam
            // 
            this.btn_exam.Font = new System.Drawing.Font("Maven Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exam.Location = new System.Drawing.Point(160, 3);
            this.btn_exam.Name = "btn_exam";
            this.btn_exam.Size = new System.Drawing.Size(151, 78);
            this.btn_exam.TabIndex = 0;
            this.btn_exam.Text = "Examination";
            this.btn_exam.UseVisualStyleBackColor = true;
            // 
            // btn_profile
            // 
            this.btn_profile.Font = new System.Drawing.Font("Maven Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.Location = new System.Drawing.Point(3, 3);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(151, 78);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 45);
            this.panel2.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Maven Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(98, 38);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Logout";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // StudentControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 145);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentControlPanel";
            this.Text = "Student Panel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_question;
        private System.Windows.Forms.Button btn_exam;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
    }
}