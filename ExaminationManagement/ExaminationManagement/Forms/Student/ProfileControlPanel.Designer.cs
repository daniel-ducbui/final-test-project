namespace ExaminationManagement.Forms.Student
{
    partial class ProfileControlPanel
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
            this.tb_name = new LollipopTextBox();
            this.tb_id = new LollipopTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_phoneNumber = new LollipopTextBox();
            this.tb_email = new LollipopTextBox();
            this.mtb_dob = new System.Windows.Forms.MaskedTextBox();
            this.tb_address = new LollipopTextBox();
            this.tb_class = new LollipopTextBox();
            this.tb_grade = new LollipopTextBox();
            this.btn_save = new LollipopButton();
            this.btn_cancel = new LollipopFlatButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_grade);
            this.panel1.Controls.Add(this.tb_class);
            this.panel1.Controls.Add(this.tb_address);
            this.panel1.Controls.Add(this.mtb_dob);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_phoneNumber);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 313);
            this.panel1.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.FocusedColor = "#508ef5";
            this.tb_name.FontColor = "#000000";
            this.tb_name.IsEnabled = true;
            this.tb_name.Location = new System.Drawing.Point(160, 44);
            this.tb_name.MaxLength = 32767;
            this.tb_name.Multiline = false;
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = false;
            this.tb_name.Size = new System.Drawing.Size(300, 24);
            this.tb_name.TabIndex = 10;
            this.tb_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_name.UseSystemPasswordChar = false;
            // 
            // tb_id
            // 
            this.tb_id.FocusedColor = "#508ef5";
            this.tb_id.FontColor = "#ff271d";
            this.tb_id.IsEnabled = true;
            this.tb_id.Location = new System.Drawing.Point(160, 14);
            this.tb_id.MaxLength = 32767;
            this.tb_id.Multiline = false;
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(300, 24);
            this.tb_id.TabIndex = 9;
            this.tb_id.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_id.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Day of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_cancel);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Location = new System.Drawing.Point(12, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 63);
            this.panel3.TabIndex = 2;
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.FocusedColor = "#508ef5";
            this.tb_phoneNumber.FontColor = "#000000";
            this.tb_phoneNumber.IsEnabled = true;
            this.tb_phoneNumber.Location = new System.Drawing.Point(160, 74);
            this.tb_phoneNumber.MaxLength = 32767;
            this.tb_phoneNumber.Multiline = false;
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.ReadOnly = false;
            this.tb_phoneNumber.Size = new System.Drawing.Size(300, 24);
            this.tb_phoneNumber.TabIndex = 11;
            this.tb_phoneNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_phoneNumber.UseSystemPasswordChar = false;
            // 
            // tb_email
            // 
            this.tb_email.FocusedColor = "#508ef5";
            this.tb_email.FontColor = "#000000";
            this.tb_email.IsEnabled = true;
            this.tb_email.Location = new System.Drawing.Point(160, 104);
            this.tb_email.MaxLength = 32767;
            this.tb_email.Multiline = false;
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = false;
            this.tb_email.Size = new System.Drawing.Size(300, 24);
            this.tb_email.TabIndex = 12;
            this.tb_email.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_email.UseSystemPasswordChar = false;
            // 
            // mtb_dob
            // 
            this.mtb_dob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtb_dob.Culture = new System.Globalization.CultureInfo("vi-VN");
            this.mtb_dob.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_dob.Location = new System.Drawing.Point(160, 134);
            this.mtb_dob.Mask = "00/00/0000";
            this.mtb_dob.Name = "mtb_dob";
            this.mtb_dob.Size = new System.Drawing.Size(300, 19);
            this.mtb_dob.TabIndex = 13;
            this.mtb_dob.ValidatingType = typeof(System.DateTime);
            // 
            // tb_address
            // 
            this.tb_address.FocusedColor = "#508ef5";
            this.tb_address.FontColor = "#000000";
            this.tb_address.IsEnabled = true;
            this.tb_address.Location = new System.Drawing.Point(160, 163);
            this.tb_address.MaxLength = 32767;
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.ReadOnly = false;
            this.tb_address.Size = new System.Drawing.Size(300, 77);
            this.tb_address.TabIndex = 14;
            this.tb_address.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_address.UseSystemPasswordChar = false;
            // 
            // tb_class
            // 
            this.tb_class.FocusedColor = "#508ef5";
            this.tb_class.FontColor = "#000000";
            this.tb_class.IsEnabled = true;
            this.tb_class.Location = new System.Drawing.Point(160, 246);
            this.tb_class.MaxLength = 32767;
            this.tb_class.Multiline = false;
            this.tb_class.Name = "tb_class";
            this.tb_class.ReadOnly = false;
            this.tb_class.Size = new System.Drawing.Size(300, 24);
            this.tb_class.TabIndex = 15;
            this.tb_class.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_class.UseSystemPasswordChar = false;
            // 
            // tb_grade
            // 
            this.tb_grade.FocusedColor = "#508ef5";
            this.tb_grade.FontColor = "#000000";
            this.tb_grade.IsEnabled = true;
            this.tb_grade.Location = new System.Drawing.Point(160, 276);
            this.tb_grade.MaxLength = 32767;
            this.tb_grade.Multiline = false;
            this.tb_grade.Name = "tb_grade";
            this.tb_grade.ReadOnly = false;
            this.tb_grade.Size = new System.Drawing.Size(300, 24);
            this.tb_grade.TabIndex = 16;
            this.tb_grade.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_grade.UseSystemPasswordChar = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BGColor = "#508ef5";
            this.btn_save.FontColor = "#ffffff";
            this.btn_save.Location = new System.Drawing.Point(238, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(231, 57);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FontColor = "#ff271d";
            this.btn_cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(229, 57);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Done";
            // 
            // ProfileControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 469);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ProfileControlPanel";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileControlPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private LollipopTextBox tb_name;
        private LollipopTextBox tb_id;
        private LollipopTextBox tb_grade;
        private LollipopTextBox tb_class;
        private LollipopTextBox tb_address;
        private System.Windows.Forms.MaskedTextBox mtb_dob;
        private LollipopTextBox tb_email;
        private LollipopTextBox tb_phoneNumber;
        private LollipopFlatButton btn_cancel;
        private LollipopButton btn_save;
    }
}