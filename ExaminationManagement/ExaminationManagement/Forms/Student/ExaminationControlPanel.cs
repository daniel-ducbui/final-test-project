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

namespace ExaminationManagement.Forms
{

    public partial class ExaminationControlPanel : Form, IExamination
    {
        ExaminationPresenter examinationPresenter;
        int userID;
        string a = null;
        string b = null;
        string c = null;
        string d = null;
        string e = null;
        string f = null;
        public ExaminationControlPanel(int userID) : this()
        {
            this.userID = userID;
        }
        public ExaminationControlPanel()
        {
            InitializeComponent();
            Load += ExaminationControlPanel_Load;
            btn_back.Click += Btn_back_Click;
            SaveAnswer();
        }

        private void SaveAnswer()
        {

            if (cb_choiceA.Checked)
            {
                a = "A";
            }
            if (cb_choiceB.Checked)
            {
                b = "B";
            }
            if (cb_choiceC.Checked)
            {
                c = "C";
            }
            if (cb_choiceD.Checked)
            {
                d = "D";
            }
            if (cb_choiceE.Checked)
            {
                e = "E";
            }
            if (cb_choiceF.Checked)
            {
                f = "F";
            }
        }

        private void Btn_prev_Click(object sender, EventArgs e)
        {
            PrevQuestion?.Invoke(this, null);
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            SaveAnswer();
            NextQuestion?.Invoke(this, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExaminationControlPanel_Load(object sender, EventArgs e)
        {
            examinationPresenter = new ExaminationPresenter(this);
            btn_next.Click += Btn_next_Click;
            btn_prev.Click += Btn_prev_Click;

        }
        public event EventHandler ChooseAnswer;
        public event EventHandler LoadQuestion;
        public event EventHandler NextQuestion;
        public event EventHandler PrevQuestion;
        public event EventHandler<IExamination.SelectedChangedEventArgs> selectedChangedQuestion;

        public string questionContent { get => rtb_contentQuestion.Text; set => rtb_contentQuestion.Text = value; }
        public string choiceA { get => a; set => cb_choiceA.Text = value; }
        public string choiceB { get => b; set => cb_choiceB.Text = value; }
        public string choiceC { get => c; set => cb_choiceC.Text = value; }
        public string choiceD { get => d; set => cb_choiceD.Text = value; }
        public string choiceE { get => e; set => cb_choiceE.Text = value; }
        public string choiceF { get => f; set => cb_choiceF.Text = value; }
    }
}
