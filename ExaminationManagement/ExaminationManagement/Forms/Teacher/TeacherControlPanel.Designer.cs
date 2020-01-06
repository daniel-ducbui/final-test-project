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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new LollipopButton();
            this.btn_question = new LollipopButton();
            this.btn_student = new LollipopButton();
            this.btn_examination = new LollipopButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_question);
            this.panel1.Controls.Add(this.btn_student);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_examination);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 165);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Location = new System.Drawing.Point(12, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 48);
            this.panel2.TabIndex = 0;
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
            this.pictureBox2.Image = global::ExaminationManagement.Properties.Resources.icons8_management_48__1_;
            this.pictureBox2.Location = new System.Drawing.Point(3, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExaminationManagement.Properties.Resources.icons8_management_48;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BGColor = "#ed5245";
            this.btn_logout.FontColor = "#ffffff";
            this.btn_logout.Location = new System.Drawing.Point(3, 3);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(466, 42);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Log Out";
            // 
            // btn_question
            // 
            this.btn_question.BackColor = System.Drawing.Color.Transparent;
            this.btn_question.BGColor = "#508ef5";
            this.btn_question.FontColor = "#ffffff";
            this.btn_question.Location = new System.Drawing.Point(55, 111);
            this.btn_question.Name = "btn_question";
            this.btn_question.Size = new System.Drawing.Size(412, 48);
            this.btn_question.TabIndex = 3;
            this.btn_question.Text = "Question Management";
            // 
            // btn_student
            // 
            this.btn_student.BackColor = System.Drawing.Color.Transparent;
            this.btn_student.BGColor = "#508ef5";
            this.btn_student.FontColor = "#ffffff";
            this.btn_student.Location = new System.Drawing.Point(55, 57);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(412, 48);
            this.btn_student.TabIndex = 2;
            this.btn_student.Text = "Student Management";
            // 
            // btn_examination
            // 
            this.btn_examination.BackColor = System.Drawing.Color.Transparent;
            this.btn_examination.BGColor = "#508ef5";
            this.btn_examination.FontColor = "#ffffff";
            this.btn_examination.Location = new System.Drawing.Point(55, 3);
            this.btn_examination.Name = "btn_examination";
            this.btn_examination.Size = new System.Drawing.Size(412, 48);
            this.btn_examination.TabIndex = 0;
            this.btn_examination.Text = "Examination Management";
            // 
            // TeacherControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherControlPanel";
            this.Text = "TeacherControlPanel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LollipopButton btn_question;
        private LollipopButton btn_student;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopButton btn_examination;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private LollipopButton btn_logout;
    }
}