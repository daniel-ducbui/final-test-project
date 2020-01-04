namespace ExaminationManagement.Forms.Student
{
    partial class ResultControlPanel
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
            this.lsc_info = new LollipopSmallCard();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_data = new MetroFramework.Controls.MetroGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_print = new LollipopFlatButton();
            this.btn_back = new LollipopFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_totalScore = new LollipopLabel();
            this.tb_examinationName = new LollipopTextBox();
            this.tb_times = new LollipopTextBox();
            this.tb_testID = new LollipopTextBox();
            this.tb_resultID = new LollipopTextBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsc_info
            // 
            this.lsc_info.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lsc_info.FontColor = "#508ef5";
            this.lsc_info.Image = global::ExaminationManagement.Properties.Resources.icons8_male_user_48;
            this.lsc_info.Info = "Info";
            this.lsc_info.Location = new System.Drawing.Point(0, 102);
            this.lsc_info.Name = "lsc_info";
            this.lsc_info.Size = new System.Drawing.Size(640, 52);
            this.lsc_info.TabIndex = 0;
            this.lsc_info.Text = "lollipopSmallCard1";
            this.lsc_info.ThumbnailColor = "#e7e8e9";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_data);
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 325);
            this.panel1.TabIndex = 1;
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_data.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_data.Location = new System.Drawing.Point(12, 3);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data.Size = new System.Drawing.Size(616, 319);
            this.dgv_data.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 44);
            this.panel2.TabIndex = 2;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.FontColor = "#508ef5";
            this.btn_print.Location = new System.Drawing.Point(530, 1);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(105, 38);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FontColor = "#ff271d";
            this.btn_back.Location = new System.Drawing.Point(3, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(105, 38);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.lb_totalScore);
            this.panel3.Controls.Add(this.tb_examinationName);
            this.panel3.Controls.Add(this.tb_times);
            this.panel3.Controls.Add(this.tb_testID);
            this.panel3.Controls.Add(this.tb_resultID);
            this.panel3.Controls.Add(this.lollipopLabel3);
            this.panel3.Controls.Add(this.lollipopLabel2);
            this.panel3.Controls.Add(this.lollipopLabel1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 124);
            this.panel3.TabIndex = 3;
            // 
            // lb_totalScore
            // 
            this.lb_totalScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_totalScore.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalScore.ForeColor = System.Drawing.Color.Blue;
            this.lb_totalScore.Location = new System.Drawing.Point(498, 33);
            this.lb_totalScore.Name = "lb_totalScore";
            this.lb_totalScore.Size = new System.Drawing.Size(68, 54);
            this.lb_totalScore.TabIndex = 5;
            this.lb_totalScore.Text = "10";
            this.lb_totalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_examinationName
            // 
            this.tb_examinationName.FocusedColor = "#508ef5";
            this.tb_examinationName.FontColor = "#000";
            this.tb_examinationName.IsEnabled = true;
            this.tb_examinationName.Location = new System.Drawing.Point(79, 3);
            this.tb_examinationName.MaxLength = 32767;
            this.tb_examinationName.Multiline = false;
            this.tb_examinationName.Name = "tb_examinationName";
            this.tb_examinationName.ReadOnly = true;
            this.tb_examinationName.Size = new System.Drawing.Size(487, 24);
            this.tb_examinationName.TabIndex = 4;
            this.tb_examinationName.Text = "Mid-exam";
            this.tb_examinationName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_examinationName.UseSystemPasswordChar = false;
            // 
            // tb_times
            // 
            this.tb_times.FocusedColor = "#508ef5";
            this.tb_times.FontColor = "#000";
            this.tb_times.IsEnabled = true;
            this.tb_times.Location = new System.Drawing.Point(79, 93);
            this.tb_times.MaxLength = 32767;
            this.tb_times.Multiline = false;
            this.tb_times.Name = "tb_times";
            this.tb_times.ReadOnly = true;
            this.tb_times.Size = new System.Drawing.Size(72, 24);
            this.tb_times.TabIndex = 3;
            this.tb_times.Text = "10";
            this.tb_times.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_times.UseSystemPasswordChar = false;
            // 
            // tb_testID
            // 
            this.tb_testID.FocusedColor = "#508ef5";
            this.tb_testID.FontColor = "#000";
            this.tb_testID.IsEnabled = true;
            this.tb_testID.Location = new System.Drawing.Point(79, 63);
            this.tb_testID.MaxLength = 32767;
            this.tb_testID.Multiline = false;
            this.tb_testID.Name = "tb_testID";
            this.tb_testID.ReadOnly = true;
            this.tb_testID.Size = new System.Drawing.Size(72, 24);
            this.tb_testID.TabIndex = 2;
            this.tb_testID.Text = "TM01";
            this.tb_testID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_testID.UseSystemPasswordChar = false;
            // 
            // tb_resultID
            // 
            this.tb_resultID.FocusedColor = "#508ef5";
            this.tb_resultID.FontColor = "#000";
            this.tb_resultID.IsEnabled = true;
            this.tb_resultID.Location = new System.Drawing.Point(79, 33);
            this.tb_resultID.MaxLength = 32767;
            this.tb_resultID.Multiline = false;
            this.tb_resultID.Name = "tb_resultID";
            this.tb_resultID.ReadOnly = true;
            this.tb_resultID.Size = new System.Drawing.Size(72, 24);
            this.tb_resultID.TabIndex = 1;
            this.tb_resultID.Text = "1";
            this.tb_resultID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_resultID.UseSystemPasswordChar = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel3.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel3.Location = new System.Drawing.Point(3, 93);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(51, 20);
            this.lollipopLabel3.TabIndex = 0;
            this.lollipopLabel3.Text = "Times";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel2.Location = new System.Drawing.Point(3, 63);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(57, 20);
            this.lollipopLabel2.TabIndex = 0;
            this.lollipopLabel2.Text = "TestID";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.Black;
            this.lollipopLabel1.Location = new System.Drawing.Point(3, 33);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(72, 20);
            this.lollipopLabel1.TabIndex = 0;
            this.lollipopLabel1.Text = "ResultID";
            // 
            // ResultControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsc_info);
            this.MaximizeBox = false;
            this.Name = "ResultControlPanel";
            this.Text = "Your Result Details";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LollipopSmallCard lsc_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LollipopFlatButton btn_back;
        private MetroFramework.Controls.MetroGrid dgv_data;
        private LollipopFlatButton btn_print;
        private System.Windows.Forms.Panel panel3;
        private LollipopTextBox tb_resultID;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox tb_testID;
        private LollipopLabel lollipopLabel2;
        private LollipopTextBox tb_times;
        private LollipopLabel lollipopLabel3;
        private LollipopTextBox tb_examinationName;
        private LollipopLabel lb_totalScore;
    }
}