namespace ExaminationManagement.Forms.CustomMessageBox
{
    partial class frmOK
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
            this.btn_ok = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lb_message = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Depth = 0;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(198, 215);
            this.btn_ok.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Primary = true;
            this.btn_ok.Size = new System.Drawing.Size(108, 29);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // lb_message
            // 
            this.lb_message.Depth = 0;
            this.lb_message.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_message.Location = new System.Drawing.Point(12, 83);
            this.lb_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(480, 113);
            this.lb_message.TabIndex = 1;
            this.lb_message.Text = "lb_message";
            // 
            // frmOK
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 274);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_ok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOK";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btn_ok;
        private MaterialSkin.Controls.MaterialLabel lb_message;
    }
}