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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_question = new LollipopButton();
            this.btn_exam = new LollipopButton();
            this.btn_profile = new LollipopButton();
            this.btn_logout = new LollipopButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Location = new System.Drawing.Point(12, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_question);
            this.panel3.Controls.Add(this.btn_exam);
            this.panel3.Controls.Add(this.btn_profile);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(12, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 165);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ExaminationManagement.Properties.Resources.icons8_help_48;
            this.pictureBox3.Location = new System.Drawing.Point(3, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExaminationManagement.Properties.Resources.icons8_exam_48;
            this.pictureBox2.Location = new System.Drawing.Point(3, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExaminationManagement.Properties.Resources.icons8_male_user_48;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_question
            // 
            this.btn_question.BackColor = System.Drawing.Color.Transparent;
            this.btn_question.BGColor = "#508ef5";
            this.btn_question.FontColor = "#ffffff";
            this.btn_question.Location = new System.Drawing.Point(57, 111);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(412, 48);
            this.btn_question.TabIndex = 4;
            this.btn_question.Text = "Question";
            // 
            // btn_exam
            // 
            this.btn_exam.BackColor = System.Drawing.Color.Transparent;
            this.btn_exam.BGColor = "#508ef5";
            this.btn_exam.FontColor = "#ffffff";
            this.btn_exam.Location = new System.Drawing.Point(57, 57);
            this.btn_exam.Name = "btn_exam";
            this.btn_exam.Size = new System.Drawing.Size(412, 48);
            this.btn_exam.TabIndex = 3;
            this.btn_exam.Text = "Examination";
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.Transparent;
            this.btn_profile.BGColor = "#508ef5";
            this.btn_profile.FontColor = "#ffffff";
            this.btn_profile.Location = new System.Drawing.Point(57, 3);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(412, 48);
            this.btn_profile.TabIndex = 2;
            this.btn_profile.Text = "Profile";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BGColor = "#ed5245";
            this.btn_logout.FontColor = "#ffffff";
            this.btn_logout.Location = new System.Drawing.Point(4, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(466, 41);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Log Out";
            // 
            // StudentControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 310);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "StudentControlPanel";
            this.Text = "Student Panel";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private LollipopButton btn_logout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LollipopButton btn_question;
        private LollipopButton btn_exam;
        private LollipopButton btn_profile;
    }
}