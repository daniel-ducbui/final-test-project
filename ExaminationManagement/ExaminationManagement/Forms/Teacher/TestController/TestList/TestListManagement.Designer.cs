namespace ExaminationManagement.Forms.Teacher.TestController
{
    partial class TestListManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_testListName = new LollipopTextBox();
            this.tb_testListID = new LollipopTextBox();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_back = new LollipopFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_testManager = new LollipopButton();
            this.btn_delete = new LollipopFlatButton();
            this.btn_edit = new LollipopButton();
            this.btn_create = new LollipopButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_testList = new MetroFramework.Controls.MetroGrid();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_testList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tb_testListName);
            this.panel1.Controls.Add(this.tb_testListID);
            this.panel1.Controls.Add(this.lollipopLabel2);
            this.panel1.Controls.Add(this.lollipopLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 102);
            this.panel1.TabIndex = 0;
            // 
            // tb_testListName
            // 
            this.tb_testListName.FocusedColor = "#508ef5";
            this.tb_testListName.FontColor = "#999999";
            this.tb_testListName.IsEnabled = true;
            this.tb_testListName.Location = new System.Drawing.Point(261, 53);
            this.tb_testListName.MaxLength = 32767;
            this.tb_testListName.Multiline = false;
            this.tb_testListName.Name = "tb_testListName";
            this.tb_testListName.ReadOnly = false;
            this.tb_testListName.Size = new System.Drawing.Size(305, 24);
            this.tb_testListName.TabIndex = 2;
            this.tb_testListName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_testListName.UseSystemPasswordChar = false;
            // 
            // tb_testListID
            // 
            this.tb_testListID.FocusedColor = "#508ef5";
            this.tb_testListID.FontColor = "#999999";
            this.tb_testListID.IsEnabled = true;
            this.tb_testListID.Location = new System.Drawing.Point(261, 14);
            this.tb_testListID.MaxLength = 32767;
            this.tb_testListID.Multiline = false;
            this.tb_testListID.Name = "tb_testListID";
            this.tb_testListID.ReadOnly = false;
            this.tb_testListID.Size = new System.Drawing.Size(305, 24);
            this.tb_testListID.TabIndex = 1;
            this.tb_testListID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_testListID.UseSystemPasswordChar = false;
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(66, 53);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(146, 26);
            this.lollipopLabel2.TabIndex = 0;
            this.lollipopLabel2.Text = "Test List Name";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Maven Pro", 15F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(66, 12);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(110, 26);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "Test List ID";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_back);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 45);
            this.panel3.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FontColor = "#ed5245";
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 39);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.btn_testManager);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.btn_edit);
            this.panel4.Controls.Add(this.btn_create);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 489);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 60);
            this.panel4.TabIndex = 3;
            // 
            // btn_testManager
            // 
            this.btn_testManager.BackColor = System.Drawing.Color.Transparent;
            this.btn_testManager.BGColor = "#16C746";
            this.btn_testManager.FontColor = "#ffffff";
            this.btn_testManager.Location = new System.Drawing.Point(470, 3);
            this.btn_testManager.Name = "btn_testManager";
            this.btn_testManager.Size = new System.Drawing.Size(143, 54);
            this.btn_testManager.TabIndex = 3;
            this.btn_testManager.Text = "Test List Details";
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
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BGColor = "#508ef5";
            this.btn_edit.FontColor = "#ffffff";
            this.btn_edit.Location = new System.Drawing.Point(172, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(143, 54);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Save";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.BGColor = "#508ef5";
            this.btn_create.FontColor = "#ffffff";
            this.btn_create.Location = new System.Drawing.Point(321, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(143, 54);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_testList);
            this.panel5.Location = new System.Drawing.Point(0, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(636, 259);
            this.panel5.TabIndex = 4;
            // 
            // dgv_testList
            // 
            this.dgv_testList.AllowUserToResizeRows = false;
            this.dgv_testList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_testList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_testList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_testList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_testList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_testList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_testList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_testList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_testList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_testList.EnableHeadersVisualStyles = false;
            this.dgv_testList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_testList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_testList.Location = new System.Drawing.Point(4, 3);
            this.dgv_testList.Name = "dgv_testList";
            this.dgv_testList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_testList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_testList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_testList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_testList.Size = new System.Drawing.Size(629, 253);
            this.dgv_testList.TabIndex = 0;
            // 
            // TestListManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 549);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TestListManagement";
            this.Text = "TheTestManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_testList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private LollipopFlatButton btn_back;
        private System.Windows.Forms.Panel panel4;
        private LollipopButton btn_create;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroGrid dgv_testList;
        private LollipopTextBox tb_testListName;
        private LollipopTextBox tb_testListID;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private LollipopButton btn_edit;
        private LollipopFlatButton btn_delete;
        private LollipopButton btn_testManager;
    }
}