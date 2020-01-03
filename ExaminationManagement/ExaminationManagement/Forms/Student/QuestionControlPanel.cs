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
        string ErrorMessage = null;

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
            btn_cancel.Click += Btn_cancel_Click;
        }

        private void QuestionControlPanel_Load(object sender, EventArgs e)
        {
            questionPresenter = new QuestionPresenter(this);

            LoadQuestion?.Invoke(this, null);
        }

        int userID;
        public QuestionControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                AddQuestion?.Invoke(this, null);
                //MessageBox.Show(questionPresenter.ErrorMessage);
                MaterialMessageBox.Show(questionPresenter.ErrorMessage, "Caption", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MaterialMessageBox.Show(questionPresenter.ErrorMessage, "Caption", MessageBoxButtons.OK);
                //MessageBox.Show(questionPresenter.ErrorMessage);
            }
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            StudentControlPanel studentControlPanel = new StudentControlPanel(this.userID);
            studentControlPanel.Show();
        }

        public event EventHandler LoadQuestion;
        public event EventHandler AddQuestion;

        int IQuestion.userID => this.userID;

        public string content { get => tb_content.Text; set => tb_content.Text = value; }
        public string choiceA { get => tb_choiceA.Text; set => tb_choiceA.Text = value; }
        public string choiceB { get => tb_choiceB.Text; set => tb_choiceB.Text = value; }
        public string choiceC { get => tb_choiceC.Text; set => tb_choiceC.Text = value; }
        public string choiceD { get => tb_choiceD.Text; set => tb_choiceD.Text = value; }
        public string choiceE { get => tb_choiceE.Text; set => tb_choiceE.Text = value; }
        public string choiceF { get => tb_choiceF.Text; set => tb_choiceF.Text = value; }
        public string answer { get => tb_answer.Text; set => tb_answer.Text = value; }
        public object DataSource { get => dgv.DataSource; set => dgv.DataSource = value; }
    }
}
