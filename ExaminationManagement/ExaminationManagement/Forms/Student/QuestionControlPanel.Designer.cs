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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_content = new LollipopTextBox();
            this.tb_choiceA = new LollipopTextBox();
            this.tb_choiceB = new LollipopTextBox();
            this.tb_choiceC = new LollipopTextBox();
            this.tb_choiceD = new LollipopTextBox();
            this.tb_choiceE = new LollipopTextBox();
            this.tb_choiceF = new LollipopTextBox();
            this.tb_answer = new LollipopTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cancel = new LollipopFlatButton();
            this.btn_save = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 72);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1320, 343);
            this.dgv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.tb_answer);
            this.panel1.Controls.Add(this.tb_choiceF);
            this.panel1.Controls.Add(this.tb_choiceE);
            this.panel1.Controls.Add(this.tb_choiceD);
            this.panel1.Controls.Add(this.tb_choiceC);
            this.panel1.Controls.Add(this.tb_choiceB);
            this.panel1.Controls.Add(this.tb_choiceA);
            this.panel1.Controls.Add(this.tb_content);
            this.panel1.Location = new System.Drawing.Point(12, 422);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 389);
            this.panel1.TabIndex = 11;
            // 
            // tb_content
            // 
            this.tb_content.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_content.FocusedColor = "#508ef5";
            this.tb_content.FontColor = "#999999";
            this.tb_content.IsEnabled = true;
            this.tb_content.Location = new System.Drawing.Point(171, 14);
            this.tb_content.MaxLength = 32767;
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.ReadOnly = false;
            this.tb_content.Size = new System.Drawing.Size(1119, 98);
            this.tb_content.TabIndex = 11;
            this.tb_content.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_content.UseSystemPasswordChar = false;
            // 
            // tb_choiceA
            // 
            this.tb_choiceA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_choiceA.FocusedColor = "#508ef5";
            this.tb_choiceA.FontColor = "#999999";
            this.tb_choiceA.IsEnabled = true;
            this.tb_choiceA.Location = new System.Drawing.Point(171, 118);
            this.tb_choiceA.MaxLength = 32767;
            this.tb_choiceA.Multiline = false;
            this.tb_choiceA.Name = "tb_choiceA";
            this.tb_choiceA.ReadOnly = false;
            this.tb_choiceA.Size = new System.Drawing.Size(1009, 24);
            this.tb_choiceA.TabIndex = 12;
            this.tb_choiceA.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_choiceA.UseSystemPasswordChar = false;
            // 
            // tb_choiceB
            // 
            this.tb_choiceB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_choiceB.FocusedColor = "#508ef5";
            this.tb_choiceB.FontColor = "#999999";
            this.tb_choiceB.IsEnabled = true;
            this.tb_choiceB.Location = new System.Drawing.Point(171, 148);
            this.tb_choiceB.MaxLength = 32767;
            this.tb_choiceB.Multiline = false;
            this.tb_choiceB.Name = "tb_choiceB";
            this.tb_choiceB.ReadOnly = false;
            this.tb_choiceB.Size = new System.Drawing.Size(1009, 24);
            this.tb_choiceB.TabIndex = 13;
            this.tb_choiceB.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_choiceB.UseSystemPasswordChar = false;
            // 
            // tb_choiceC
            // 
            this.tb_choiceC.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_choiceC.FocusedColor = "#508ef5";
            this.tb_choiceC.FontColor = "#999999";
            this.tb_choiceC.IsEnabled = true;
            this.tb_choiceC.Location = new System.Drawing.Point(171, 178);
            this.tb_choiceC.MaxLength = 32767;
            this.tb_choiceC.Multiline = false;
            this.tb_choiceC.Name = "tb_choiceC";
            this.tb_choiceC.ReadOnly = false;
            this.tb_choiceC.Size = new System.Drawing.Size(1009, 24);
            this.tb_choiceC.TabIndex = 14;
            this.tb_choiceC.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_choiceC.UseSystemPasswordChar = false;
            // 
            // tb_choiceD
            // 
            this.tb_choiceD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_choiceD.FocusedColor = "#508ef5";
            this.tb_choiceD.FontColor = "#999999";
            this.tb_choiceD.IsEnabled = true;
            this.tb_choiceD.Location = new System.Drawing.Point(171, 208);
            this.tb_choiceD.MaxLength = 32767;
            this.tb_choiceD.Multiline = false;
            this.tb_choiceD.Name = "tb_choiceD";
            this.tb_choiceD.ReadOnly = false;
            this.tb_choiceD.Size = new System.Drawing.Size(1009, 24);
            this.tb_choiceD.TabIndex = 15;
            this.tb_choiceD.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_choiceD.UseSystemPasswordChar = false;
            // 
            // tb_choiceE
            // 
            this.tb_choiceE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_choiceE.FocusedColor = "#508ef5";
            this.tb_choiceE.FontColor = "#999999";
            this.tb_choiceE.IsEnabled = true;
            this.tb_choiceE.Location = new System.Drawing.Point(171, 238);
            this.tb_choiceE.MaxLength = 32767;
            this.tb_choiceE.Multiline = false;
            this.tb_choiceE.Name = "tb_choiceE";
            this.tb_choiceE.ReadOnly = false;
            this.tb_choiceE.Size = new System.Drawing.Size(1009, 24);
            this.tb_choiceE.TabIndex = 16;
            this.tb_choiceE.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_choiceE.UseSystemPasswordChar = false;
            // 
            // tb_choiceF
            // 
            this.tb_choiceF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_choiceF.FocusedColor = "#508ef5";
            this.tb_choiceF.FontColor = "#999999";
            this.tb_choiceF.IsEnabled = true;
            this.tb_choiceF.Location = new System.Drawing.Point(171, 268);
            this.tb_choiceF.MaxLength = 32767;
            this.tb_choiceF.Multiline = false;
            this.tb_choiceF.Name = "tb_choiceF";
            this.tb_choiceF.ReadOnly = false;
            this.tb_choiceF.Size = new System.Drawing.Size(1009, 24);
            this.tb_choiceF.TabIndex = 17;
            this.tb_choiceF.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_choiceF.UseSystemPasswordChar = false;
            // 
            // tb_answer
            // 
            this.tb_answer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_answer.FocusedColor = "#508ef5";
            this.tb_answer.FontColor = "#999999";
            this.tb_answer.IsEnabled = true;
            this.tb_answer.Location = new System.Drawing.Point(171, 298);
            this.tb_answer.MaxLength = 32767;
            this.tb_answer.Multiline = false;
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.ReadOnly = false;
            this.tb_answer.Size = new System.Drawing.Size(1009, 24);
            this.tb_answer.TabIndex = 18;
            this.tb_answer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_answer.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(90, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 21);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Question";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(145, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(20, 21);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "A";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(145, 148);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(20, 21);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "B";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(145, 178);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(20, 21);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "C";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(145, 208);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(21, 21);
            this.materialLabel5.TabIndex = 19;
            this.materialLabel5.Text = "D";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(145, 238);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(19, 21);
            this.materialLabel6.TabIndex = 19;
            this.materialLabel6.Text = "E";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(145, 268);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(19, 21);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "F";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Maven Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(102, 298);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(64, 21);
            this.materialLabel8.TabIndex = 19;
            this.materialLabel8.Text = "Answer";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FontColor = "#508ef5";
            this.btn_cancel.Location = new System.Drawing.Point(944, 328);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 49);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Cancel";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BGColor = "#508ef5";
            this.btn_save.FontColor = "#ffffff";
            this.btn_save.Location = new System.Drawing.Point(1065, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 49);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Save";
            // 
            // QuestionControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1344, 824);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Maven Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuestionControlPanel";
            this.Text = "Sugguest Questions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel1;
        private LollipopTextBox tb_content;
        private LollipopButton btn_save;
        private LollipopFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private LollipopTextBox tb_answer;
        private LollipopTextBox tb_choiceF;
        private LollipopTextBox tb_choiceE;
        private LollipopTextBox tb_choiceD;
        private LollipopTextBox tb_choiceC;
        private LollipopTextBox tb_choiceB;
        private LollipopTextBox tb_choiceA;
    }
}