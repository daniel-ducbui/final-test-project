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
        int userID;
        public AddQuestionControlPanel()
        {
            InitializeComponent();
            addQuestionPresenter = new AddQuestionPresenter(this);
            Load += AddQuestionControlPanel_Load;
            btn_back.Click += Btn_back_Click;
            btn_new.Click += Btn_save_Click;
            btn_update.Click += Btn_update_Click;
        }
        private void Btn_update_Click(object sender, EventArgs e)
        {
            UpdateQuestion?.Invoke(this, null);
        }

        private void AddQuestionControlPanel_Load(object sender, EventArgs e)
        {
            LoadTheQuestion?.Invoke(this, null);
        }

        public AddQuestionControlPanel(int _userID) : this()
        {
            this.userID = _userID;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            SaveQuestion?.Invoke(this, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public event EventHandler SaveQuestion;
        public event EventHandler LoadTheQuestion;
        public event EventHandler UpdateQuestion;

        int IAddQuestion.userID => this.userID;

        public RichTextBox questionContent { get => rtb_contentQuestion; set => rtb_contentQuestion = value; }
        public TextBox choiceA { get => txt_choiceA; set => txt_choiceA = value; }
        public TextBox choiceB { get => txt_choiceB; set => txt_choiceB = value; }
        public TextBox choiceC { get => txt_choiceC; set => txt_choiceC = value; }
        public TextBox choiceD { get => txt_choiceD; set => txt_choiceD = value; }
        public TextBox choiceE { get => txt_choiceE; set => txt_choiceE = value; }
        public TextBox choiceF { get => txt_choiceF; set => txt_choiceF = value; }
        public TextBox answer { get => txt_answer; set => txt_answer = value; }
        public DataGridView dgvTheQuestion { get => dgv_theQuestion; set => dgv_theQuestion = value; }
    }
}
