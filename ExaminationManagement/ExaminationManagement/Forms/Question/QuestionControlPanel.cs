using ExaminationManagement.Forms.CustomMessageBox;
using ExaminationManagement.Presenters.Student;
using ExaminationManagement.Views.Student;
using MaterialSkin.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Student
{
    public partial class QuestionControlPanel : MaterialForm, IQuestion
    {
        QuestionPresenter questionPresenter;
        string errorMessage = null;

        int userID;
        int questionID;
        int permission = 2;
        string answer = null;
        string[] previousAnswers = null;
        string[] answers = null;

        int flagChangeColor = 0;

        public QuestionControlPanel()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();

            Load += QuestionControlPanel_Load;
            btn_save.Click += Btn_save_Click;
            btn_back.Click += Btn_cancel_Click;
            btn_add.Click += Btn_add_Click;
        }

        public QuestionControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void QuestionControlPanel_Load(object sender, EventArgs e)
        {
            questionPresenter = new QuestionPresenter(this);

            if (this.permission == 2)
            {
                btn_edit.Hide();
                btn_import.Hide();
                cb_questionType.Hide();
            }
            else
            {
                btn_edit.Click += Btn_edit_Click;
                btn_import.Click += Btn_import_Click;
                btn_export.Click += Btn_export_Click;
                dgv_data.DoubleClick += Dgv_DoubleClick;
                cb_questionType.SelectedIndexChanged += Cb_questionType_SelectedIndexChanged;
            }

            LoadQuestion?.Invoke(this, null);
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {

        }

        private void Cb_questionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // I am here. Teacher choose what kind of question to review
        }

        private void Dgv_DoubleClick(object sender, EventArgs e)
        {
            Btn_edit_Click(sender, e);
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                this.answer = this.GetCheckedAnswer();

                AddQuestion?.Invoke(this, null);

                if (!String.IsNullOrEmpty(this.errorMessage))
                {
                    MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
                    this.OnClear();
                }
            }
            catch (Exception)
            {
                MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                this.OnChangeColor();
                this.OnClear();
                int index = dgv_data.SelectedCells[0].RowIndex;

                this.questionID = Convert.ToInt32(dgv_data.Rows[index].Cells[0].Value.ToString());

                ShowQuestion?.Invoke(this, null);

                this.flagChangeColor = 1;
                this.OnSetPreviousAnswer();

                if (!String.IsNullOrEmpty(this.errorMessage))
                {
                    MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                this.answer = this.GetCheckedAnswer();

                EditQuestion?.Invoke(this, null);

                if (!String.IsNullOrEmpty(this.errorMessage))
                {
                    MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
                    this.OnClear();
                }
            }
            catch (Exception)
            {
                MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
            }
        }

        private void Btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                if (openQuestionDataFile.ShowDialog() == DialogResult.OK)
                {
                    ImportQuestion?.Invoke(this, null);

                    if (!String.IsNullOrEmpty(this.errorMessage))
                    {
                        MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(this.errorMessage, "Warning", MessageBoxButtons.OK);
            }
        }

        string GetCheckedAnswer()
        {
            answer = null;

            if (!ckb_choiceA.Checked && !ckb_choiceB.Checked && !ckb_choiceC.Checked && !ckb_choiceD.Checked && !ckb_choiceE.Checked && !ckb_choiceF.Checked)
            {
                answer = "null";
            }
            else
            {
                if (ckb_choiceA.Checked)
                {
                    answer += "a-";
                    ckb_choiceA.Checked = false;
                }
                if (ckb_choiceB.Checked)
                {
                    answer += "b-";
                    ckb_choiceB.Checked = false;
                }
                if (ckb_choiceC.Checked)
                {
                    answer += "c-";
                    ckb_choiceC.Checked = false;
                }
                if (ckb_choiceD.Checked)
                {
                    answer += "d-";
                    ckb_choiceD.Checked = false;
                }
                if (ckb_choiceE.Checked)
                {
                    answer += "e-";
                    ckb_choiceE.Checked = false;
                }
                if (ckb_choiceF.Checked)
                {
                    answer += "f-";
                    ckb_choiceF.Checked = false;
                }
            }

            return answer;
        }

        void SetPreviousAnswers(string[] previousAnswers)
        {
            foreach (var item in previousAnswers)
            {
                if (item.Contains("a"))
                {
                    ckb_choiceA.Checked = true;

                    if (this.flagChangeColor == 1)
                    {
                        tb_a.BackColor = Color.Lime;
                    }
                }
                if (item.Contains("b"))
                {
                    ckb_choiceB.Checked = true;

                    if (this.flagChangeColor == 1)
                    {
                        tb_b.BackColor = Color.Lime;
                    }
                }
                if (item.Contains("c"))
                {
                    ckb_choiceC.Checked = true;

                    if (this.flagChangeColor == 1)
                    {
                        tb_c.BackColor = Color.Lime;
                    }
                }
                if (item.Contains("d"))
                {
                    ckb_choiceD.Checked = true;

                    if (this.flagChangeColor == 1)
                    {
                        tb_d.BackColor = Color.Lime;
                    }
                }
                if (item.Contains("e"))
                {
                    ckb_choiceE.Checked = true;

                    if (this.flagChangeColor == 1)
                    {
                        tb_e.BackColor = Color.Lime;
                    }
                }
                if (item.Contains("f"))
                {
                    ckb_choiceF.Checked = true;

                    if (this.flagChangeColor == 1)
                    {
                        tb_f.BackColor = Color.Lime;
                    }
                }

            }
            this.flagChangeColor = 0;
        }

        void OnChangeColor()
        {
            tb_a.BackColor = Color.Snow;
            tb_b.BackColor = Color.Snow;
            tb_c.BackColor = Color.Snow;
            tb_d.BackColor = Color.Snow;
            tb_e.BackColor = Color.Snow;
            tb_f.BackColor = Color.Snow;
        }

        void OnSetPreviousAnswer()
        {
            this.answers = this.previousAnswers;

            if (answers != null)
            {
                this.SetPreviousAnswers(answers);

                answers = null;
            }
        }

        void OnClear()
        {
            tb_content.Text = null;
            tb_a.Text = null;
            tb_b.Text = null;
            tb_c.Text = null;
            tb_d.Text = null;
            tb_e.Text = null;
            tb_f.Text = null;

            ckb_choiceA.Checked = false;
            ckb_choiceB.Checked = false;
            ckb_choiceC.Checked = false;
            ckb_choiceD.Checked = false;
            ckb_choiceE.Checked = false;
            ckb_choiceF.Checked = false;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (this.permission == 2)
            {
                StudentControlPanel studentControlPanel = new StudentControlPanel(this.userID);
                studentControlPanel.Show();
            }
            else
            {
                TeacherControlPanel teacherControlPanel = new TeacherControlPanel(this.userID);
                teacherControlPanel.Show();
            }
        }

        public event EventHandler LoadQuestion;
        public event EventHandler AddQuestion;
        public event EventHandler ShowQuestion;
        public event EventHandler EditQuestion;
        public event EventHandler ImportQuestion;

        int IQuestion.userID => this.userID;
        int IQuestion.permission { get => this.permission; set => this.permission = value; }
        int IQuestion.questionID => this.questionID;

        public string content { get => tb_content.Text; set => tb_content.Text = value; }
        public string choiceA { get => tb_a.Text; set => tb_a.Text = value; }
        public string choiceB { get => tb_b.Text; set => tb_b.Text = value; }
        public string choiceC { get => tb_c.Text; set => tb_c.Text = value; }
        public string choiceD { get => tb_d.Text; set => tb_d.Text = value; }
        public string choiceE { get => tb_e.Text; set => tb_e.Text = value; }
        public string choiceF { get => tb_f.Text; set => tb_f.Text = value; }
        string[] IQuestion.previousAnswers { get => this.previousAnswers; set => this.previousAnswers = value; }
        string IQuestion.fileName { get => this.openQuestionDataFile.FileName; set => this.openQuestionDataFile.FileName = value; }
        string IQuestion.answer { get => this.answer; set => this.answer = value; }
        public object DataSource { get => dgv_data.DataSource; set => dgv_data.DataSource = value; }
        string IQuestion.errorMessage { get => this.errorMessage; set => this.errorMessage = value; }
    }
}
