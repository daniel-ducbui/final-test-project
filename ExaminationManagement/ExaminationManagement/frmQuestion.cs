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
    public partial class frmQuestion : Form,IQuestionView
    {
        QuestionPresenter presenter;

        public object DataGridViewItems
        { get
            {
                return dgvListQuestion.DataSource;
            }
            set
            {
                dgvListQuestion.DataSource = value;
            }
        }
        public TextBox questionID { get => txtQuestionID; set => txtQuestionID = value; }
        public TextBox level { get => txtLevel; set => txtLevel = value; }
        public RichTextBox content { get => rtxtContent; set => rtxtContent = value; }
        public TextBox choiceA { get => txtChoiceA; set => txtChoiceA = value; }
        public TextBox choiceB { get => txtChoiceB; set => txtChoiceB = value; }
        public TextBox choiceC { get => txtChoiceC; set => txtChoiceC=value; }
        public TextBox choiceD { get => txtChoiceD; set => txtChoiceD=value; }
        public TextBox choiceE { get => txtChoiceE; set => txtChoiceE=value; }
        public TextBox choiceF { get => txtChoiceF; set => txtChoiceF=value; }
        public TextBox correctAnswer { get => txtCorrectAnswer; set =>txtCorrectAnswer=value; }
       

        public frmQuestion()
        {
            InitializeComponent();
            Load += FrmQuestion_Load;
        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            presenter = new QuestionPresenter(this);
           

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
