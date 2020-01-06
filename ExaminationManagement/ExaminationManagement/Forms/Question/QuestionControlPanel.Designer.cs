namespace ExaminationManagement.Forms.Student
{
    partial class QuestionControlPanel
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
            this.btn_import = new LollipopButton();
            this.btn_edit = new LollipopButton();
            this.btn_add = new LollipopButton();
            this.ckb_choiceF = new LollipopCheckBox();
            this.ckb_choiceE = new LollipopCheckBox();
            this.ckb_choiceD = new LollipopCheckBox();
            this.ckb_choiceC = new LollipopCheckBox();
            this.ckb_choiceB = new LollipopCheckBox();
            this.ckb_choiceA = new LollipopCheckBox();
            this.btn_save = new LollipopButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_f = new LollipopTextBox();
            this.tb_e = new LollipopTextBox();
            this.tb_d = new LollipopTextBox();
            this.tb_c = new LollipopTextBox();
            this.tb_b = new LollipopTextBox();
            this.tb_a = new LollipopTextBox();
            this.tb_content = new LollipopTextBox();
            this.dgv_data = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new LollipopFlatButton();
            this.openQuestionDataFile = new System.Windows.Forms.OpenFileDialog();
            this.cb_questionType = new MetroFramework.Controls.MetroComboBox();
            this.btn_export = new LollipopButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Controls.Add(this.btn_import);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.ckb_choiceF);
            this.panel1.Controls.Add(this.ckb_choiceE);
            this.panel1.Controls.Add(this.ckb_choiceD);
            this.panel1.Controls.Add(this.ckb_choiceC);
            this.panel1.Controls.Add(this.ckb_choiceB);
            this.panel1.Controls.Add(this.ckb_choiceA);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.tb_f);
            this.panel1.Controls.Add(this.tb_e);
            this.panel1.Controls.Add(this.tb_d);
            this.panel1.Controls.Add(this.tb_c);
            this.panel1.Controls.Add(this.tb_b);
            this.panel1.Controls.Add(this.tb_a);
            this.panel1.Controls.Add(this.tb_content);
            this.panel1.Location = new System.Drawing.Point(12, 500);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 307);
            this.panel1.TabIndex = 11;
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.Transparent;
            this.btn_import.BGColor = "#508ef5";
            this.btn_import.FontColor = "#ffffff";
            this.btn_import.Location = new System.Drawing.Point(1202, 127);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(115, 49);
            this.btn_import.TabIndex = 30;
            this.btn_import.Text = "Import";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BGColor = "#508ef5";
            this.btn_edit.FontColor = "#ffffff";
            this.btn_edit.Location = new System.Drawing.Point(1202, 13);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(115, 49);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "Edit";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BGColor = "#508ef5";
            this.btn_add.FontColor = "#ffffff";
            this.btn_add.Location = new System.Drawing.Point(1202, 182);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 49);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "Add";
            // 
            // ckb_choiceF
            // 
            this.ckb_choiceF.AutoSize = true;
            this.ckb_choiceF.CheckColor = "#508ef5";
            this.ckb_choiceF.Location = new System.Drawing.Point(1015, 271);
            this.ckb_choiceF.Name = "ckb_choiceF";
            this.ckb_choiceF.Size = new System.Drawing.Size(20, 20);
            this.ckb_choiceF.TabIndex = 27;
            this.ckb_choiceF.UseVisualStyleBackColor = true;
            // 
            // ckb_choiceE
            // 
            this.ckb_choiceE.AutoSize = true;
            this.ckb_choiceE.CheckColor = "#508ef5";
            this.ckb_choiceE.Location = new System.Drawing.Point(1015, 241);
            this.ckb_choiceE.Name = "ckb_choiceE";
            this.ckb_choiceE.Size = new System.Drawing.Size(20, 20);
            this.ckb_choiceE.TabIndex = 26;
            this.ckb_choiceE.UseVisualStyleBackColor = true;
            // 
            // ckb_choiceD
            // 
            this.ckb_choiceD.AutoSize = true;
            this.ckb_choiceD.CheckColor = "#508ef5";
            this.ckb_choiceD.Location = new System.Drawing.Point(1015, 211);
            this.ckb_choiceD.Name = "ckb_choiceD";
            this.ckb_choiceD.Size = new System.Drawing.Size(20, 20);
            this.ckb_choiceD.TabIndex = 25;
            this.ckb_choiceD.UseVisualStyleBackColor = true;
            // 
            // ckb_choiceC
            // 
            this.ckb_choiceC.AutoSize = true;
            this.ckb_choiceC.CheckColor = "#508ef5";
            this.ckb_choiceC.Location = new System.Drawing.Point(1015, 181);
            this.ckb_choiceC.Name = "ckb_choiceC";
            this.ckb_choiceC.Size = new System.Drawing.Size(20, 20);
            this.ckb_choiceC.TabIndex = 24;
            this.ckb_choiceC.UseVisualStyleBackColor = true;
            // 
            // ckb_choiceB
            // 
            this.ckb_choiceB.AutoSize = true;
            this.ckb_choiceB.CheckColor = "#508ef5";
            this.ckb_choiceB.Location = new System.Drawing.Point(1015, 151);
            this.ckb_choiceB.Name = "ckb_choiceB";
            this.ckb_choiceB.Size = new System.Drawing.Size(20, 20);
            this.ckb_choiceB.TabIndex = 23;
            this.ckb_choiceB.UseVisualStyleBackColor = true;
            // 
            // ckb_choiceA
            // 
            this.ckb_choiceA.AutoSize = true;
            this.ckb_choiceA.CheckColor = "#508ef5";
            this.ckb_choiceA.Location = new System.Drawing.Point(1015, 121);
            this.ckb_choiceA.Name = "ckb_choiceA";
            this.ckb_choiceA.Size = new System.Drawing.Size(20, 20);
            this.ckb_choiceA.TabIndex = 22;
            this.ckb_choiceA.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BGColor = "#508ef5";
            this.btn_save.FontColor = "#ffffff";
            this.btn_save.Location = new System.Drawing.Point(1202, 237);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 49);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Save";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(58, 267);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(17, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "F";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(58, 237);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(18, 19);
            this.materialLabel6.TabIndex = 19;
            this.materialLabel6.Text = "E";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(58, 207);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(19, 19);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "D";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(58, 177);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(19, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "C";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(58, 147);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(18, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "B";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(58, 117);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(19, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "A";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Question";
            // 
            // tb_f
            // 
            this.tb_f.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_f.FocusedColor = "#508ef5";
            this.tb_f.FontColor = "#999999";
            this.tb_f.IsEnabled = true;
            this.tb_f.Location = new System.Drawing.Point(84, 267);
            this.tb_f.MaxLength = 32767;
            this.tb_f.Multiline = false;
            this.tb_f.Name = "tb_f";
            this.tb_f.ReadOnly = false;
            this.tb_f.Size = new System.Drawing.Size(925, 24);
            this.tb_f.TabIndex = 17;
            this.tb_f.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_f.UseSystemPasswordChar = false;
            // 
            // tb_e
            // 
            this.tb_e.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_e.FocusedColor = "#508ef5";
            this.tb_e.FontColor = "#999999";
            this.tb_e.IsEnabled = true;
            this.tb_e.Location = new System.Drawing.Point(84, 237);
            this.tb_e.MaxLength = 32767;
            this.tb_e.Multiline = false;
            this.tb_e.Name = "tb_e";
            this.tb_e.ReadOnly = false;
            this.tb_e.Size = new System.Drawing.Size(925, 24);
            this.tb_e.TabIndex = 16;
            this.tb_e.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_e.UseSystemPasswordChar = false;
            // 
            // tb_d
            // 
            this.tb_d.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_d.FocusedColor = "#508ef5";
            this.tb_d.FontColor = "#999999";
            this.tb_d.IsEnabled = true;
            this.tb_d.Location = new System.Drawing.Point(84, 207);
            this.tb_d.MaxLength = 32767;
            this.tb_d.Multiline = false;
            this.tb_d.Name = "tb_d";
            this.tb_d.ReadOnly = false;
            this.tb_d.Size = new System.Drawing.Size(925, 24);
            this.tb_d.TabIndex = 15;
            this.tb_d.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_d.UseSystemPasswordChar = false;
            // 
            // tb_c
            // 
            this.tb_c.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_c.FocusedColor = "#508ef5";
            this.tb_c.FontColor = "#999999";
            this.tb_c.IsEnabled = true;
            this.tb_c.Location = new System.Drawing.Point(84, 177);
            this.tb_c.MaxLength = 32767;
            this.tb_c.Multiline = false;
            this.tb_c.Name = "tb_c";
            this.tb_c.ReadOnly = false;
            this.tb_c.Size = new System.Drawing.Size(925, 24);
            this.tb_c.TabIndex = 14;
            this.tb_c.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_c.UseSystemPasswordChar = false;
            // 
            // tb_b
            // 
            this.tb_b.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_b.FocusedColor = "#508ef5";
            this.tb_b.FontColor = "#999999";
            this.tb_b.IsEnabled = true;
            this.tb_b.Location = new System.Drawing.Point(84, 147);
            this.tb_b.MaxLength = 32767;
            this.tb_b.Multiline = false;
            this.tb_b.Name = "tb_b";
            this.tb_b.ReadOnly = false;
            this.tb_b.Size = new System.Drawing.Size(925, 24);
            this.tb_b.TabIndex = 13;
            this.tb_b.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_b.UseSystemPasswordChar = false;
            // 
            // tb_a
            // 
            this.tb_a.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_a.FocusedColor = "#508ef5";
            this.tb_a.FontColor = "#999999";
            this.tb_a.IsEnabled = true;
            this.tb_a.Location = new System.Drawing.Point(84, 117);
            this.tb_a.MaxLength = 32767;
            this.tb_a.Multiline = false;
            this.tb_a.Name = "tb_a";
            this.tb_a.ReadOnly = false;
            this.tb_a.Size = new System.Drawing.Size(925, 24);
            this.tb_a.TabIndex = 12;
            this.tb_a.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_a.UseSystemPasswordChar = false;
            // 
            // tb_content
            // 
            this.tb_content.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_content.FocusedColor = "#508ef5";
            this.tb_content.FontColor = "#999999";
            this.tb_content.IsEnabled = true;
            this.tb_content.Location = new System.Drawing.Point(84, 13);
            this.tb_content.MaxLength = 32767;
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.ReadOnly = false;
            this.tb_content.Size = new System.Drawing.Size(1035, 98);
            this.tb_content.TabIndex = 11;
            this.tb_content.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_content.UseSystemPasswordChar = false;
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToResizeRows = false;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_data.Location = new System.Drawing.Point(12, 149);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(1320, 344);
            this.dgv_data.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 47);
            this.panel2.TabIndex = 29;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FontColor = "#ff213d";
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(115, 41);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Back";
            // 
            // openQuestionDataFile
            // 
            this.openQuestionDataFile.FileName = "openFileDialog1";
            // 
            // cb_questionType
            // 
            this.cb_questionType.FormattingEnabled = true;
            this.cb_questionType.ItemHeight = 23;
            this.cb_questionType.Items.AddRange(new object[] {
            "Teacher\'s Questions",
            "Student\'s Questions"});
            this.cb_questionType.Location = new System.Drawing.Point(12, 117);
            this.cb_questionType.Name = "cb_questionType";
            this.cb_questionType.Size = new System.Drawing.Size(121, 29);
            this.cb_questionType.TabIndex = 30;
            this.cb_questionType.UseSelectable = true;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.Transparent;
            this.btn_export.BGColor = "#508ef5";
            this.btn_export.FontColor = "#ffffff";
            this.btn_export.Location = new System.Drawing.Point(1202, 70);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(115, 51);
            this.btn_export.TabIndex = 31;
            this.btn_export.Text = "Export";
            // 
            // QuestionControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1344, 818);
            this.Controls.Add(this.cb_questionType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Maven Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuestionControlPanel";
            this.Text = "Sugguest Questions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private LollipopTextBox tb_content;
        private LollipopButton btn_save;
        private LollipopFlatButton btn_back;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private LollipopTextBox tb_f;
        private LollipopTextBox tb_e;
        private LollipopTextBox tb_d;
        private LollipopTextBox tb_c;
        private LollipopTextBox tb_b;
        private LollipopTextBox tb_a;
        private LollipopCheckBox ckb_choiceF;
        private LollipopCheckBox ckb_choiceE;
        private LollipopCheckBox ckb_choiceD;
        private LollipopCheckBox ckb_choiceC;
        private LollipopCheckBox ckb_choiceB;
        private LollipopCheckBox ckb_choiceA;
        private MetroFramework.Controls.MetroGrid dgv_data;
        private LollipopButton btn_add;
        private System.Windows.Forms.Panel panel2;
        private LollipopButton btn_edit;
        private LollipopButton btn_import;
        private System.Windows.Forms.OpenFileDialog openQuestionDataFile;
        private MetroFramework.Controls.MetroComboBox cb_questionType;
        private LollipopButton btn_export;
    }
}