using ExaminationManagement.Presenters;
using ExaminationManagement.Presenters.Student;
using ExaminationManagement.Views.Student;
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
    public partial class AddQuestionControlPanel : Form, IAddQuestion
    {
        AddQuestionPresenter addQuestionPresenter;

        public AddQuestionControlPanel()
        {
            InitializeComponent();
            cb_levelQuestion.SelectedIndex = 0;
            btn_back.Click += Btn_back_Click;
            btn_save.Click += Btn_save_Click;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            addQuestionPresenter = new AddQuestionPresenter(this);
            SaveQuestion?.Invoke(this, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler SaveQuestion;
        public string questionLevel { get => cb_levelQuestion.Text; set => cb_levelQuestion.Text = value; }
        public string questionContent { get => rtb_contentQuestion.Text; set => rtb_contentQuestion.Text = value; }
        public string choiceA { get => txt_choiceA.Text; set => txt_choiceA.Text = value; }
        public string choiceB { get => txt_choiceB.Text; set => txt_choiceB.Text = value; }
        public string choiceC { get => txt_choiceC.Text; set => txt_choiceC.Text = value; }
        public string choiceD { get => txt_choiceD.Text; set => txt_choiceD.Text = value; }
        public string choiceE { get => txt_choiceE.Text; set => txt_choiceE.Text = value; }
        public string choiceF { get => txt_choiceF.Text; set => txt_choiceF.Text = value; }
        public string answer { get => txt_answer.Text; set => txt_answer.Text = value; }
        public int userID { get => 0; set => userID = value; }
    }
}
