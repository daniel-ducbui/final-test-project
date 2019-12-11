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
        StudentControlPanel studentControlPanel;
        ExaminationPresenter studentPresenter;

       

        public ExaminationControlPanel()
        {
            InitializeComponent();
            Load += ExaminationControlPanel_Load;
            btn_back.Click += Btn_back_Click;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            studentControlPanel = new StudentControlPanel();
            studentControlPanel.FormClosed += (s, args) => this.Close();
            studentControlPanel.Show();
        }

        private void ExaminationControlPanel_Load(object sender, EventArgs e)
        {
            studentPresenter = new ExaminationPresenter(this);
            LoadQuestion?.Invoke(this, null);

        }
        public event EventHandler LoadQuestion;
        public event EventHandler ChooseAnswer;
        public RichTextBox questionContent { get => rtb_contentQuestion; set => rtb_contentQuestion = value; }
        public CheckBox choiceA { get => cb_choiceA; set => cb_choiceA = value; }
        public CheckBox choiceB { get => cb_choiceB; set => cb_choiceB = value; }
        public CheckBox choiceC { get => cb_choiceC; set => cb_choiceC = value; }
        public CheckBox choiceD { get => cb_choiceD; set => cb_choiceD = value; }
        public CheckBox choiceE { get => cb_choiceE; set => cb_choiceE = value; }
        public CheckBox choiceF { get => cb_choiceF; set => cb_choiceE = value; }
        public string answer { get => ""; set => answer = value; }
    }
}
