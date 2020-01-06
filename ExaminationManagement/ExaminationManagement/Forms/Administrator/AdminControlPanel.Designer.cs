namespace ExaminationManagement.Forms
{
    partial class AdminControlPanel
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
            this.dgv_table = new MetroFramework.Controls.MetroGrid();
            this.openUserDataFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new LollipopButton();
            this.btn_add = new LollipopButton();
            this.btn_edit = new LollipopButton();
            this.btn_loadData = new LollipopButton();
            this.btn_readData = new LollipopButton();
            this.btn_logout = new LollipopFlatButton();
            this.tb_search = new LollipopTextBox();
            this.cb_table = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToResizeRows = false;
            this.dgv_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_table.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_table.EnableHeadersVisualStyles = false;
            this.dgv_table.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_table.Location = new System.Drawing.Point(3, 3);
            this.dgv_table.MultiSelect = false;
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_table.Size = new System.Drawing.Size(919, 424);
            this.dgv_table.TabIndex = 2;
            // 
            // openUserDataFile
            // 
            this.openUserDataFile.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_table);
            this.panel1.Location = new System.Drawing.Point(12, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 430);
            this.panel1.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BGColor = "#508ef5";
            this.btn_search.FontColor = "#ffffff";
            this.btn_search.Location = new System.Drawing.Point(943, 70);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 30);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BGColor = "#508ef5";
            this.btn_add.FontColor = "#ffffff";
            this.btn_add.Location = new System.Drawing.Point(943, 137);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 41);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add User";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BGColor = "#508ef5";
            this.btn_edit.FontColor = "#ffffff";
            this.btn_edit.Location = new System.Drawing.Point(943, 184);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(143, 41);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit User Details";
            // 
            // btn_loadData
            // 
            this.btn_loadData.BackColor = System.Drawing.Color.Transparent;
            this.btn_loadData.BGColor = "#508ef5";
            this.btn_loadData.FontColor = "#ffffff";
            this.btn_loadData.Location = new System.Drawing.Point(943, 231);
            this.btn_loadData.Name = "btn_loadData";
            this.btn_loadData.Size = new System.Drawing.Size(143, 41);
            this.btn_loadData.TabIndex = 9;
            this.btn_loadData.Text = "Load User";
            // 
            // btn_readData
            // 
            this.btn_readData.BackColor = System.Drawing.Color.Transparent;
            this.btn_readData.BGColor = "#508ef5";
            this.btn_readData.FontColor = "#ffffff";
            this.btn_readData.Location = new System.Drawing.Point(943, 278);
            this.btn_readData.Name = "btn_readData";
            this.btn_readData.Size = new System.Drawing.Size(143, 41);
            this.btn_readData.TabIndex = 10;
            this.btn_readData.Text = "Import User";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FontColor = "#ff271d";
            this.btn_logout.Location = new System.Drawing.Point(943, 527);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(143, 41);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "Log Out";
            // 
            // tb_search
            // 
            this.tb_search.FocusedColor = "#508ef5";
            this.tb_search.FontColor = "#999999";
            this.tb_search.IsEnabled = true;
            this.tb_search.Location = new System.Drawing.Point(12, 76);
            this.tb_search.MaxLength = 32767;
            this.tb_search.Multiline = false;
            this.tb_search.Name = "tb_search";
            this.tb_search.ReadOnly = false;
            this.tb_search.Size = new System.Drawing.Size(925, 24);
            this.tb_search.TabIndex = 12;
            this.tb_search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_search.UseSystemPasswordChar = false;
            // 
            // cb_table
            // 
            this.cb_table.FormattingEnabled = true;
            this.cb_table.ItemHeight = 23;
            this.cb_table.Items.AddRange(new object[] {
            "Accounts",
            "AccountDetails"});
            this.cb_table.Location = new System.Drawing.Point(12, 106);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(179, 29);
            this.cb_table.TabIndex = 13;
            this.cb_table.UseSelectable = true;
            // 
            // AdminControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 578);
            this.Controls.Add(this.cb_table);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_readData);
            this.Controls.Add(this.btn_loadData);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel1);
            this.Name = "AdminControlPanel";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openUserDataFile;
        private MetroFramework.Controls.MetroGrid dgv_table;
        private System.Windows.Forms.Panel panel1;
        private LollipopButton btn_search;
        private LollipopButton btn_add;
        private LollipopButton btn_edit;
        private LollipopButton btn_loadData;
        private LollipopButton btn_readData;
        private LollipopFlatButton btn_logout;
        private LollipopTextBox tb_search;
        private MetroFramework.Controls.MetroComboBox cb_table;
    }
}