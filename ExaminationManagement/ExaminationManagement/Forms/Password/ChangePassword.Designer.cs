namespace ExaminationManagement.Forms.Password
{
    partial class ChangePassword
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
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.tb_oldPassword = new LollipopTextBox();
            this.tb_newPassword = new LollipopTextBox();
            this.tb_confirmNewPassword = new LollipopTextBox();
            this.btn_confirm = new LollipopButton();
            this.btn_cancel = new LollipopFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_confirmNewPassword);
            this.panel1.Controls.Add(this.tb_newPassword);
            this.panel1.Controls.Add(this.tb_oldPassword);
            this.panel1.Controls.Add(this.lollipopLabel3);
            this.panel1.Controls.Add(this.lollipopLabel2);
            this.panel1.Controls.Add(this.lollipopLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 120);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_confirm);
            this.panel2.Location = new System.Drawing.Point(12, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 50);
            this.panel2.TabIndex = 0;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(3, 15);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(129, 24);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Old Password";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(3, 45);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(139, 24);
            this.lollipopLabel2.TabIndex = 0;
            this.lollipopLabel2.Text = "New Password";
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(3, 75);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(214, 24);
            this.lollipopLabel3.TabIndex = 0;
            this.lollipopLabel3.Text = "Confirm New Password";
            // 
            // tb_oldPassword
            // 
            this.tb_oldPassword.FocusedColor = "#508ef5";
            this.tb_oldPassword.FontColor = "#999999";
            this.tb_oldPassword.IsEnabled = true;
            this.tb_oldPassword.Location = new System.Drawing.Point(237, 15);
            this.tb_oldPassword.MaxLength = 32767;
            this.tb_oldPassword.Multiline = false;
            this.tb_oldPassword.Name = "tb_oldPassword";
            this.tb_oldPassword.ReadOnly = false;
            this.tb_oldPassword.Size = new System.Drawing.Size(279, 24);
            this.tb_oldPassword.TabIndex = 1;
            this.tb_oldPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_oldPassword.UseSystemPasswordChar = true;
            // 
            // tb_newPassword
            // 
            this.tb_newPassword.FocusedColor = "#508ef5";
            this.tb_newPassword.FontColor = "#999999";
            this.tb_newPassword.IsEnabled = true;
            this.tb_newPassword.Location = new System.Drawing.Point(237, 45);
            this.tb_newPassword.MaxLength = 32767;
            this.tb_newPassword.Multiline = false;
            this.tb_newPassword.Name = "tb_newPassword";
            this.tb_newPassword.ReadOnly = false;
            this.tb_newPassword.Size = new System.Drawing.Size(279, 24);
            this.tb_newPassword.TabIndex = 2;
            this.tb_newPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_newPassword.UseSystemPasswordChar = true;
            // 
            // tb_confirmNewPassword
            // 
            this.tb_confirmNewPassword.FocusedColor = "#508ef5";
            this.tb_confirmNewPassword.FontColor = "#999999";
            this.tb_confirmNewPassword.IsEnabled = true;
            this.tb_confirmNewPassword.Location = new System.Drawing.Point(237, 75);
            this.tb_confirmNewPassword.MaxLength = 32767;
            this.tb_confirmNewPassword.Multiline = false;
            this.tb_confirmNewPassword.Name = "tb_confirmNewPassword";
            this.tb_confirmNewPassword.ReadOnly = false;
            this.tb_confirmNewPassword.Size = new System.Drawing.Size(279, 24);
            this.tb_confirmNewPassword.TabIndex = 3;
            this.tb_confirmNewPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_confirmNewPassword.UseSystemPasswordChar = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.BGColor = "#508ef5";
            this.btn_confirm.FontColor = "#ffffff";
            this.btn_confirm.Location = new System.Drawing.Point(282, 3);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(260, 44);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Confirm";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FontColor = "#ff271d";
            this.btn_cancel.Location = new System.Drawing.Point(3, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(260, 44);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 276);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LollipopTextBox tb_confirmNewPassword;
        private LollipopTextBox tb_newPassword;
        private LollipopTextBox tb_oldPassword;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private LollipopFlatButton btn_cancel;
        private LollipopButton btn_confirm;
    }
}