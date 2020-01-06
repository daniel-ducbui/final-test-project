namespace ExaminationManagement.Forms.Teacher.ExamineeController
{
    partial class ExamineeListManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_examinee = new MetroFramework.Controls.MetroGrid();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_back = new LollipopFlatButton();
            this.btn_examineeManager = new LollipopButton();
            this.btn_delete = new LollipopFlatButton();
            this.btn_create = new LollipopButton();
            this.btn_cancel = new LollipopFlatButton();
            this.tb_examineeName = new LollipopTextBox();
            this.tb_examineeListID = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examinee)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 45);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_examinee);
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 259);
            this.panel2.TabIndex = 6;
            // 
            // dgv_examinee
            // 
            this.dgv_examinee.AllowUserToResizeRows = false;
            this.dgv_examinee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_examinee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_examinee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_examinee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_examinee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_examinee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_examinee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_examinee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_examinee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_examinee.EnableHeadersVisualStyles = false;
            this.dgv_examinee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_examinee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_examinee.Location = new System.Drawing.Point(4, 3);
            this.dgv_examinee.MultiSelect = false;
            this.dgv_examinee.Name = "dgv_examinee";
            this.dgv_examinee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_examinee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_examinee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_examinee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_examinee.Size = new System.Drawing.Size(629, 253);
            this.dgv_examinee.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.btn_examineeManager);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.btn_create);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 489);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 60);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_cancel);
            this.panel3.Controls.Add(this.tb_examineeName);
            this.panel3.Controls.Add(this.tb_examineeListID);
            this.panel3.Controls.Add(this.lollipopLabel2);
            this.panel3.Controls.Add(this.lollipopLabel1);
            this.panel3.Location = new System.Drawing.Point(0, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 104);
            this.panel3.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FontColor = "#ed5245";
            this.btn_back.Location = new System.Drawing.Point(3, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(105, 39);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            // 
            // btn_examineeManager
            // 
            this.btn_examineeManager.BackColor = System.Drawing.Color.Transparent;
            this.btn_examineeManager.BGColor = "#16C746";
            this.btn_examineeManager.FontColor = "#ffffff";
            this.btn_examineeManager.Location = new System.Drawing.Point(470, 3);
            this.btn_examineeManager.Name = "btn_examineeManager";
            this.btn_examineeManager.Size = new System.Drawing.Size(143, 54);
            this.btn_examineeManager.TabIndex = 3;
            this.btn_examineeManager.Text = "Examinee Details";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FontColor = "#ed5245";
            this.btn_delete.Location = new System.Drawing.Point(23, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(143, 54);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.BGColor = "#508ef5";
            this.btn_create.FontColor = "#ffffff";
            this.btn_create.Location = new System.Drawing.Point(172, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(292, 54);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Save";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FontColor = "#ed5245";
            this.btn_cancel.Location = new System.Drawing.Point(518, 24);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(98, 54);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            // 
            // tb_examineeName
            // 
            this.tb_examineeName.FocusedColor = "#508ef5";
            this.tb_examineeName.FontColor = "#999999";
            this.tb_examineeName.IsEnabled = true;
            this.tb_examineeName.Location = new System.Drawing.Point(212, 54);
            this.tb_examineeName.MaxLength = 32767;
            this.tb_examineeName.Multiline = false;
            this.tb_examineeName.Name = "tb_examineeName";
            this.tb_examineeName.ReadOnly = false;
            this.tb_examineeName.Size = new System.Drawing.Size(300, 24);
            this.tb_examineeName.TabIndex = 2;
            this.tb_examineeName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_examineeName.UseSystemPasswordChar = false;
            // 
            // tb_examineeListID
            // 
            this.tb_examineeListID.FocusedColor = "#508ef5";
            this.tb_examineeListID.FontColor = "#999999";
            this.tb_examineeListID.IsEnabled = true;
            this.tb_examineeListID.Location = new System.Drawing.Point(212, 24);
            this.tb_examineeListID.MaxLength = 32767;
            this.tb_examineeListID.Multiline = false;
            this.tb_examineeListID.Name = "tb_examineeListID";
            this.tb_examineeListID.ReadOnly = true;
            this.tb_examineeListID.Size = new System.Drawing.Size(300, 24);
            this.tb_examineeListID.TabIndex = 1;
            this.tb_examineeListID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_examineeListID.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(44, 52);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(162, 26);
            this.lollipopLabel2.TabIndex = 0;
            this.lollipopLabel2.Text = "Examinee Name";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(44, 22);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(120, 26);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "ExamineeID";
            // 
            // ExamineeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "ExamineeManagement";
            this.Text = "ExamineeManagement";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_examinee)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LollipopFlatButton btn_back;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid dgv_examinee;
        private System.Windows.Forms.Panel panel4;
        private LollipopButton btn_examineeManager;
        private LollipopFlatButton btn_delete;
        private LollipopButton btn_create;
        private System.Windows.Forms.Panel panel3;
        private LollipopFlatButton btn_cancel;
        private LollipopTextBox tb_examineeName;
        private LollipopTextBox tb_examineeListID;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
    }
}