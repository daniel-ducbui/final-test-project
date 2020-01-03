namespace ExaminationManagement.Forms.CustomMessageBox
{
    partial class frmYesNo
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
            this.btn_no = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_yes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lb_message = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.Depth = 0;
            this.btn_no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_no.Location = new System.Drawing.Point(286, 213);
            this.btn_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_no.Name = "btn_no";
            this.btn_no.Primary = true;
            this.btn_no.Size = new System.Drawing.Size(108, 29);
            this.btn_no.TabIndex = 0;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            // 
            // btn_yes
            // 
            this.btn_yes.Depth = 0;
            this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_yes.Location = new System.Drawing.Point(86, 213);
            this.btn_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Primary = true;
            this.btn_yes.Size = new System.Drawing.Size(108, 29);
            this.btn_yes.TabIndex = 0;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = true;
            // 
            // lb_message
            // 
            this.lb_message.Depth = 0;
            this.lb_message.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_message.Location = new System.Drawing.Point(12, 81);
            this.lb_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(480, 113);
            this.lb_message.TabIndex = 1;
            this.lb_message.Text = "materialLabel1";
            // 
            // frmYesNo
            // 
            this.AcceptButton = this.btn_yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 274);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.btn_no);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYesNo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_no;
        private MaterialSkin.Controls.MaterialRaisedButton btn_yes;
        private MaterialSkin.Controls.MaterialLabel lb_message;
    }
}