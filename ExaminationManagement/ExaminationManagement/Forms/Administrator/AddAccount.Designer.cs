namespace ExaminationManagement.Forms.Administrator
{
    partial class AddAccount
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
            this.mtb_dob = new System.Windows.Forms.MaskedTextBox();
            this.cb_permission = new MetroFramework.Controls.MetroComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new LollipopButton();
            this.btn_add = new LollipopButton();
            this.btn_cancel = new LollipopFlatButton();
            this.tb_password = new LollipopTextBox();
            this.tb_gradeID = new LollipopTextBox();
            this.tb_classID = new LollipopTextBox();
            this.tb_address = new LollipopTextBox();
            this.tb_email = new LollipopTextBox();
            this.tb_phoneNumber = new LollipopTextBox();
            this.tb_name = new LollipopTextBox();
            this.lollipopLabel9 = new LollipopLabel();
            this.lollipopLabel8 = new LollipopLabel();
            this.lollipopLabel7 = new LollipopLabel();
            this.lollipopLabel6 = new LollipopLabel();
            this.lollipopLabel5 = new LollipopLabel();
            this.lollipopLabel4 = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtb_dob
            // 
            this.mtb_dob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtb_dob.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_dob.Location = new System.Drawing.Point(186, 174);
            this.mtb_dob.Mask = "00/00/0000";
            this.mtb_dob.Name = "mtb_dob";
            this.mtb_dob.Size = new System.Drawing.Size(300, 19);
            this.mtb_dob.TabIndex = 4;
            this.mtb_dob.ValidatingType = typeof(System.DateTime);
            // 
            // cb_permission
            // 
            this.cb_permission.FormattingEnabled = true;
            this.cb_permission.ItemHeight = 23;
            this.cb_permission.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_permission.Location = new System.Drawing.Point(186, 289);
            this.cb_permission.Name = "cb_permission";
            this.cb_permission.Size = new System.Drawing.Size(121, 29);
            this.cb_permission.TabIndex = 8;
            this.cb_permission.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Location = new System.Drawing.Point(12, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 52);
            this.panel1.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BGColor = "#508ef5";
            this.btn_save.FontColor = "#ffffff";
            this.btn_save.Location = new System.Drawing.Point(165, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(146, 46);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BGColor = "#508ef5";
            this.btn_add.FontColor = "#ffffff";
            this.btn_add.Location = new System.Drawing.Point(325, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(146, 46);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FontColor = "#508ef5";
            this.btn_cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(146, 46);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Done";
            // 
            // tb_password
            // 
            this.tb_password.FocusedColor = "#508ef5";
            this.tb_password.FontColor = "#999999";
            this.tb_password.IsEnabled = true;
            this.tb_password.Location = new System.Drawing.Point(186, 324);
            this.tb_password.MaxLength = 32767;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.ReadOnly = false;
            this.tb_password.Size = new System.Drawing.Size(300, 24);
            this.tb_password.TabIndex = 9;
            this.tb_password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_gradeID
            // 
            this.tb_gradeID.FocusedColor = "#508ef5";
            this.tb_gradeID.FontColor = "#999999";
            this.tb_gradeID.IsEnabled = true;
            this.tb_gradeID.Location = new System.Drawing.Point(186, 259);
            this.tb_gradeID.MaxLength = 32767;
            this.tb_gradeID.Multiline = false;
            this.tb_gradeID.Name = "tb_gradeID";
            this.tb_gradeID.ReadOnly = false;
            this.tb_gradeID.Size = new System.Drawing.Size(300, 24);
            this.tb_gradeID.TabIndex = 7;
            this.tb_gradeID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_gradeID.UseSystemPasswordChar = false;
            // 
            // tb_classID
            // 
            this.tb_classID.FocusedColor = "#508ef5";
            this.tb_classID.FontColor = "#999999";
            this.tb_classID.IsEnabled = true;
            this.tb_classID.Location = new System.Drawing.Point(186, 229);
            this.tb_classID.MaxLength = 32767;
            this.tb_classID.Multiline = false;
            this.tb_classID.Name = "tb_classID";
            this.tb_classID.ReadOnly = false;
            this.tb_classID.Size = new System.Drawing.Size(300, 24);
            this.tb_classID.TabIndex = 6;
            this.tb_classID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_classID.UseSystemPasswordChar = false;
            // 
            // tb_address
            // 
            this.tb_address.FocusedColor = "#508ef5";
            this.tb_address.FontColor = "#999999";
            this.tb_address.IsEnabled = true;
            this.tb_address.Location = new System.Drawing.Point(186, 199);
            this.tb_address.MaxLength = 32767;
            this.tb_address.Multiline = false;
            this.tb_address.Name = "tb_address";
            this.tb_address.ReadOnly = false;
            this.tb_address.Size = new System.Drawing.Size(300, 24);
            this.tb_address.TabIndex = 5;
            this.tb_address.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_address.UseSystemPasswordChar = false;
            // 
            // tb_email
            // 
            this.tb_email.FocusedColor = "#508ef5";
            this.tb_email.FontColor = "#999999";
            this.tb_email.IsEnabled = true;
            this.tb_email.Location = new System.Drawing.Point(186, 144);
            this.tb_email.MaxLength = 32767;
            this.tb_email.Multiline = false;
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = false;
            this.tb_email.Size = new System.Drawing.Size(300, 24);
            this.tb_email.TabIndex = 3;
            this.tb_email.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_email.UseSystemPasswordChar = false;
            // 
            // tb_phoneNumber
            // 
            this.tb_phoneNumber.FocusedColor = "#508ef5";
            this.tb_phoneNumber.FontColor = "#999999";
            this.tb_phoneNumber.IsEnabled = true;
            this.tb_phoneNumber.Location = new System.Drawing.Point(186, 114);
            this.tb_phoneNumber.MaxLength = 32767;
            this.tb_phoneNumber.Multiline = false;
            this.tb_phoneNumber.Name = "tb_phoneNumber";
            this.tb_phoneNumber.ReadOnly = false;
            this.tb_phoneNumber.Size = new System.Drawing.Size(300, 24);
            this.tb_phoneNumber.TabIndex = 2;
            this.tb_phoneNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_phoneNumber.UseSystemPasswordChar = false;
            // 
            // tb_name
            // 
            this.tb_name.FocusedColor = "#508ef5";
            this.tb_name.FontColor = "#999999";
            this.tb_name.IsEnabled = true;
            this.tb_name.Location = new System.Drawing.Point(186, 84);
            this.tb_name.MaxLength = 32767;
            this.tb_name.Multiline = false;
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = false;
            this.tb_name.Size = new System.Drawing.Size(300, 24);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_name.UseSystemPasswordChar = false;
            // 
            // lollipopLabel9
            // 
            this.lollipopLabel9.AutoSize = true;
            this.lollipopLabel9.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel9.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel9.Location = new System.Drawing.Point(12, 322);
            this.lollipopLabel9.Name = "lollipopLabel9";
            this.lollipopLabel9.Size = new System.Drawing.Size(98, 26);
            this.lollipopLabel9.TabIndex = 0;
            this.lollipopLabel9.Text = "Password";
            // 
            // lollipopLabel8
            // 
            this.lollipopLabel8.AutoSize = true;
            this.lollipopLabel8.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel8.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel8.Location = new System.Drawing.Point(12, 292);
            this.lollipopLabel8.Name = "lollipopLabel8";
            this.lollipopLabel8.Size = new System.Drawing.Size(111, 26);
            this.lollipopLabel8.TabIndex = 0;
            this.lollipopLabel8.Text = "Permission";
            // 
            // lollipopLabel7
            // 
            this.lollipopLabel7.AutoSize = true;
            this.lollipopLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel7.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel7.Location = new System.Drawing.Point(12, 257);
            this.lollipopLabel7.Name = "lollipopLabel7";
            this.lollipopLabel7.Size = new System.Drawing.Size(67, 26);
            this.lollipopLabel7.TabIndex = 0;
            this.lollipopLabel7.Text = "Grade";
            // 
            // lollipopLabel6
            // 
            this.lollipopLabel6.AutoSize = true;
            this.lollipopLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel6.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel6.Location = new System.Drawing.Point(12, 227);
            this.lollipopLabel6.Name = "lollipopLabel6";
            this.lollipopLabel6.Size = new System.Drawing.Size(58, 26);
            this.lollipopLabel6.TabIndex = 0;
            this.lollipopLabel6.Text = "Class";
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(12, 197);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(83, 26);
            this.lollipopLabel5.TabIndex = 0;
            this.lollipopLabel5.Text = "Address";
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(12, 170);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(52, 26);
            this.lollipopLabel4.TabIndex = 0;
            this.lollipopLabel4.Text = "DOB";
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(12, 138);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(63, 26);
            this.lollipopLabel3.TabIndex = 0;
            this.lollipopLabel3.Text = "Email";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 112);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(149, 26);
            this.lollipopLabel2.TabIndex = 0;
            this.lollipopLabel2.Text = "Phone Number";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(12, 82);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(66, 26);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Name";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.cb_permission);
            this.Controls.Add(this.tb_gradeID);
            this.Controls.Add(this.tb_classID);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_phoneNumber);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lollipopLabel9);
            this.Controls.Add(this.lollipopLabel8);
            this.Controls.Add(this.lollipopLabel7);
            this.Controls.Add(this.mtb_dob);
            this.Controls.Add(this.lollipopLabel6);
            this.Controls.Add(this.lollipopLabel5);
            this.Controls.Add(this.lollipopLabel4);
            this.Controls.Add(this.lollipopLabel3);
            this.Controls.Add(this.lollipopLabel2);
            this.Controls.Add(this.lollipopLabel1);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LollipopLabel lollipopLabel1;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel4;
        private LollipopLabel lollipopLabel5;
        private LollipopLabel lollipopLabel6;
        private LollipopLabel lollipopLabel7;
        private LollipopLabel lollipopLabel8;
        private LollipopLabel lollipopLabel9;
        private LollipopTextBox tb_name;
        private LollipopTextBox tb_phoneNumber;
        private LollipopTextBox tb_email;
        private System.Windows.Forms.MaskedTextBox mtb_dob;
        private LollipopTextBox tb_address;
        private LollipopTextBox tb_classID;
        private LollipopTextBox tb_gradeID;
        private MetroFramework.Controls.MetroComboBox cb_permission;
        private LollipopTextBox tb_password;
        private System.Windows.Forms.Panel panel1;
        private LollipopButton btn_save;
        private LollipopButton btn_add;
        private LollipopFlatButton btn_cancel;
    }
}