namespace ExaminationManagement
{
    partial class LoginForm
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
            this.tb_username = new LollipopTextBox();
            this.tb_password = new LollipopTextBox();
            this.btn_login = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.btn_quit = new LollipopFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lollipopLabel2);
            this.panel1.Controls.Add(this.lollipopLabel1);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Location = new System.Drawing.Point(12, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 114);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_quit);
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Location = new System.Drawing.Point(12, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 47);
            this.panel2.TabIndex = 3;
            // 
            // tb_username
            // 
            this.tb_username.FocusedColor = "#508ef5";
            this.tb_username.FontColor = "#999999";
            this.tb_username.IsEnabled = true;
            this.tb_username.Location = new System.Drawing.Point(3, 32);
            this.tb_username.MaxLength = 32767;
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.ReadOnly = false;
            this.tb_username.Size = new System.Drawing.Size(307, 24);
            this.tb_username.TabIndex = 2;
            this.tb_username.Text = "ducbui2991@gmail.com";
            this.tb_username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_username.UseSystemPasswordChar = false;
            // 
            // tb_password
            // 
            this.tb_password.FocusedColor = "#508ef5";
            this.tb_password.FontColor = "#999999";
            this.tb_password.IsEnabled = true;
            this.tb_password.Location = new System.Drawing.Point(3, 79);
            this.tb_password.MaxLength = 32767;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.ReadOnly = false;
            this.tb_password.Size = new System.Drawing.Size(307, 24);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "090212A1";
            this.tb_password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BGColor = "#508ef5";
            this.btn_login.FontColor = "#ffffff";
            this.btn_login.Location = new System.Drawing.Point(167, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(143, 41);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(3, 11);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(73, 18);
            this.lollipopLabel1.TabIndex = 4;
            this.lollipopLabel1.Text = "Username";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(3, 59);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(69, 17);
            this.lollipopLabel2.TabIndex = 4;
            this.lollipopLabel2.Text = "Password";
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.FontColor = "#508ef5";
            this.btn_quit.Location = new System.Drawing.Point(3, 3);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(143, 41);
            this.btn_quit.TabIndex = 4;
            this.btn_quit.Text = "Quit";
            this.btn_quit.Click += new System.EventHandler(this.Btn_quit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 332);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Maven Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LollipopTextBox tb_username;
        private LollipopTextBox tb_password;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private LollipopButton btn_login;
        private LollipopFlatButton btn_quit;
    }
}

