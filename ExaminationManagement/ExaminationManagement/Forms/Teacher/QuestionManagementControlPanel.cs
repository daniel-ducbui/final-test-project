using ExaminationManagement.Presenters.Teacher;
using ExaminationManagement.Views.Tearcher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Teacher
{
    public partial class QuestionManagementControlPanel : Form, IQuestionManagement
    {
        QuestionManagementPresenter questionManagementPresenter;
        int userID;
        public QuestionManagementControlPanel(int userID)
        {
            InitializeComponent();
            questionManagementPresenter = new QuestionManagementPresenter(this);
            this.userID = userID;
            Load += QuestionManagementControlPanel_Load;
            btn_back.Click += Btn_back_Click;
            btn_addQuestion.Click += Btn_addQuestion_Click;
            btn_saveChange.Click += Btn_saveChange_Click;
            btn_deleteQuestion.Click += Btn_deleteQuestion_Click;
            btn_browserQuestion.Click += Btn_browserQuestion_Click;
        }

        private void Btn_browserQuestion_Click(object sender, EventArgs e)
        {
            BrowserQuestion?.Invoke(this, null);
        }

        private void Btn_deleteQuestion_Click(object sender, EventArgs e)
        {
            DeleteQuestion?.Invoke(this, null);
        }

        private void Btn_saveChange_Click(object sender, EventArgs e)
        {
            SaveChange?.Invoke(this, null);
        }

        private void Btn_addQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion?.Invoke(this, null);
        }

        private void QuestionManagementControlPanel_Load(object sender, EventArgs e)
        {
            LoadTheQuestion?.Invoke(this, null);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int IQuestionManagement.userID => this.userID;
        public DataGridView dgvTheQuestion { get => dgv_theQustion; set => dgv_theQustion = value; }
        public TextBox questionLevel { get => txt_questionLevel; set => txt_questionLevel = value; }
        public ComboBox questionType { get => cbb_questionType; set => cbb_questionType = value; }
        public RichTextBox questionContent { get => rtb_questionContent; set => rtb_questionContent = value; }
        public TextBox choiceA { get => txt_choiceA; set => txt_choiceA = value; }
        public TextBox choiceB { get => txt_choiceB; set => txt_choiceB = value; }
        public TextBox choiceC { get => txt_choiceC; set => txt_choiceC = value; }
        public TextBox choiceD { get => txt_choiceD; set => txt_choiceD = value; }
        public TextBox choiceE { get => txt_choiceE; set => txt_choiceE = value; }
        public TextBox choiceF { get => txt_choiceF; set => txt_choiceF = value; }
        public TextBox answer { get => txt_anwer; set => txt_anwer = value; }
        public Button addQuestion { get => btn_addQuestion; set => btn_addQuestion = value; }
        public Button saveChange { get => btn_saveChange; set => btn_saveChange = value; }
        public Button deleteQuestion { get => btn_deleteQuestion; set => btn_deleteQuestion = value; }
        public Button inportExcel { get => btn_importExcel; set => btn_importExcel = value; }
        public Button browserQuestion { get => btn_browserQuestion; set => btn_browserQuestion = value; }

        public event EventHandler AddQuestion;
        public event EventHandler SaveChange;
        public event EventHandler DeleteQuestion;
        public event EventHandler InportExcel;
        public event EventHandler BrowserQuestion;
        public event EventHandler LoadTheQuestion;
    }
}
