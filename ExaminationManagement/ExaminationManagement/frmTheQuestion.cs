using ExaminationManagement.Presenters;
using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement
{
    public partial class frmTheQuestion : Form, ITheQuestion
    {
        TheQuestionPresenter presenter;

        public object DataGridViewItems { get => dgvListQuestion.DataSource; set => dgvListQuestion.DataSource = value; }
        public TextBox QuestionID { get => txtQuestionID; set => txtQuestionID = value; }
        public TextBox QuestionLevel { get => txtLevel; set => txtLevel = value; }
        //public TextBox QuestionType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public RichTextBox QuestionContent { get => rtxtContent; set => rtxtContent = value; }
        public TextBox ChoiceA { get => txtChoiceA; set => txtChoiceA = value; }
        public TextBox ChoiceB { get => txtChoiceB; set => txtChoiceB = value; }
        public TextBox ChoiceC { get => txtChoiceC; set => txtChoiceC = value; }
        public TextBox ChoiceD { get => txtChoiceD; set => txtChoiceD = value; }
        public TextBox ChoiceE { get => txtChoiceE; set => txtChoiceE = value; }
        public TextBox ChoiceF { get => txtChoiceF; set => txtChoiceF = value; }
        public TextBox Answer { get => txtCorrectAnswer; set => txtCorrectAnswer = value; }

        public frmTheQuestion()
        {
            InitializeComponent();
            Load += FrmTheQuestion_Load;
        }

        private void FrmTheQuestion_Load(object sender, EventArgs e)
        {
            presenter = new TheQuestionPresenter(this);

            btnNew.Click += BtnNew_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteQuestion?.Invoke(this, null);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateQuestion?.Invoke(this, null);
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            NewQuestion?.Invoke(this, null);

        }
   
        public event EventHandler NewQuestion;
        public event EventHandler UpdateQuestion;
        public event EventHandler DeleteQuestion;
        public event EventHandler<SelectedChangedEventArgs> SelectedChangeQuestion;
    }
}
