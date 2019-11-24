namespace ExaminationManagement
{
    partial class frmQuestion
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
            this.dgvListQuestion = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChoiceF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChoiceE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChoiceD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChoiceC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChoiceB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChoiceA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListQuestion)).BeginInit();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListQuestion
            // 
            this.dgvListQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListQuestion.Location = new System.Drawing.Point(3, 25);
            this.dgvListQuestion.Name = "dgvListQuestion";
            this.dgvListQuestion.Size = new System.Drawing.Size(1207, 275);
            this.dgvListQuestion.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(109, 685);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 48);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(962, 685);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(691, 685);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 48);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.btnImport);
            this.grb1.Controls.Add(this.txtQuestionID);
            this.grb1.Controls.Add(this.label10);
            this.grb1.Controls.Add(this.rtxtContent);
            this.grb1.Controls.Add(this.txtCorrectAnswer);
            this.grb1.Controls.Add(this.label9);
            this.grb1.Controls.Add(this.txtChoiceF);
            this.grb1.Controls.Add(this.label8);
            this.grb1.Controls.Add(this.txtChoiceE);
            this.grb1.Controls.Add(this.label7);
            this.grb1.Controls.Add(this.txtChoiceD);
            this.grb1.Controls.Add(this.label6);
            this.grb1.Controls.Add(this.txtChoiceC);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Controls.Add(this.txtChoiceB);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.txtChoiceA);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.txtLevel);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.btnNew);
            this.grb1.Controls.Add(this.dgvListQuestion);
            this.grb1.Controls.Add(this.btnDelete);
            this.grb1.Controls.Add(this.btnUpdate);
            this.grb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb1.Location = new System.Drawing.Point(0, 0);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(1213, 788);
            this.grb1.TabIndex = 4;
            this.grb1.TabStop = false;
            this.grb1.Text = "Quản lý câu hỏi";
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Location = new System.Drawing.Point(464, 329);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.Size = new System.Drawing.Size(358, 29);
            this.txtQuestionID.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "questionID:";
            // 
            // rtxtContent
            // 
            this.rtxtContent.Location = new System.Drawing.Point(691, 362);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(358, 96);
            this.rtxtContent.TabIndex = 22;
            this.rtxtContent.Text = "";
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.Location = new System.Drawing.Point(691, 608);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.Size = new System.Drawing.Size(358, 29);
            this.txtCorrectAnswer.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 611);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "correct answer:";
            // 
            // txtChoiceF
            // 
            this.txtChoiceF.Location = new System.Drawing.Point(109, 613);
            this.txtChoiceF.Name = "txtChoiceF";
            this.txtChoiceF.Size = new System.Drawing.Size(358, 29);
            this.txtChoiceF.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "choiceF:";
            // 
            // txtChoiceE
            // 
            this.txtChoiceE.Location = new System.Drawing.Point(691, 553);
            this.txtChoiceE.Name = "txtChoiceE";
            this.txtChoiceE.Size = new System.Drawing.Size(358, 29);
            this.txtChoiceE.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 553);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "choiceE:";
            // 
            // txtChoiceD
            // 
            this.txtChoiceD.Location = new System.Drawing.Point(109, 553);
            this.txtChoiceD.Name = "txtChoiceD";
            this.txtChoiceD.Size = new System.Drawing.Size(358, 29);
            this.txtChoiceD.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "choiceD:";
            // 
            // txtChoiceC
            // 
            this.txtChoiceC.Location = new System.Drawing.Point(691, 484);
            this.txtChoiceC.Name = "txtChoiceC";
            this.txtChoiceC.Size = new System.Drawing.Size(358, 29);
            this.txtChoiceC.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "choiceC:";
            // 
            // txtChoiceB
            // 
            this.txtChoiceB.Location = new System.Drawing.Point(109, 487);
            this.txtChoiceB.Name = "txtChoiceB";
            this.txtChoiceB.Size = new System.Drawing.Size(358, 29);
            this.txtChoiceB.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "choiceB:";
            // 
            // txtChoiceA
            // 
            this.txtChoiceA.Location = new System.Drawing.Point(109, 429);
            this.txtChoiceA.Name = "txtChoiceA";
            this.txtChoiceA.Size = new System.Drawing.Size(358, 29);
            this.txtChoiceA.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "choiceA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "content:";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(109, 364);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(358, 29);
            this.txtLevel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "level:";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(384, 685);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(83, 48);
            this.btnImport.TabIndex = 25;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 788);
            this.Controls.Add(this.grb1);
            this.Name = "frmQuestion";
            this.Text = "frmQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListQuestion)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListQuestion;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.TextBox txtChoiceF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChoiceE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChoiceD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChoiceC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChoiceB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChoiceA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuestionID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImport;
    }
}