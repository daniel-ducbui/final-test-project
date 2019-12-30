using ExaminationManagement.Functions.Events;
using ExaminationManagement.Presenters.Student.Examination;
using ExaminationManagement.Views.Student.Examination;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Student.Examination
{
    public partial class MainExamination : Form, IMainExamination
    {
        MainExaminationPresenter mainExaminationController;
        ExaminationControlPanel examinationControlPanel;
        int userID;
        int examineeListID;
        int time;
        string examInfo = null;
        string[] answers = null;
        string answer = null;
        bool nav = false;

        int currentIndex = 0;
        int maxQuestions = 0;
        string[] previousAnswers = null;

        public MainExamination()
        {
            InitializeComponent();

            Load += MainExamination_Load;
            btn_start.Click += Btn_start_Click;
            btn_next.Click += Btn_next_Click;
            btn_previous.Click += Btn_previous_Click;
            btn_submit.Click += Btn_submit_Click;
            btn_back.Click += Btn_back_Click;
        }

        public MainExamination(int userID, string examInfo, int examineeListID, int time) : this()
        {
            this.userID = userID;
            this.examInfo = examInfo;
            this.examineeListID = examineeListID;
            this.time = time;
        }

        private void MainExamination_Load(object sender, EventArgs e)
        {
            mainExaminationController = new MainExaminationPresenter(this);

            if (btn_start.Enabled)
            {
                btn_next.Enabled = btn_previous.Enabled = btn_submit.Enabled = false;
            }

            tb_content.TextChanged += (s, ev) =>
            {
                if (nav)
                {
                    nav = false;
                }
            };
        }

        private void LoadQuestions()
        {
            try
            {
                LoadQuestion?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail" + ex.Message);
            }
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                btn_start.Enabled = false;
                btn_next.Enabled = btn_previous.Enabled = btn_submit.Enabled = true;
                LoadQuestions();

                // 2nd Way
                this.answers = this.previousAnswers;

                if (answers != null)
                {
                    this.PreviouAnswers(answers);

                    answers = null;
                }
                CheckIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You have not submitted yet! ", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();

                examinationControlPanel = new ExaminationControlPanel(this.userID);
                examinationControlPanel.Show();
            }
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    answer = CheckedAnswer();

                    Submit?.Invoke(this, null);

                    answer = null;

                    this.Close();

                    examinationControlPanel = new ExaminationControlPanel(this.userID);
                    examinationControlPanel.Show();
                    MessageBox.Show(mainExaminationController.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail" + ex.Message);
            }
        }

        void CheckIndex()
        {
            if (this.currentIndex < this.maxQuestions - 1 && this.currentIndex > 0)
            {
                btn_next.Enabled = true;
                btn_previous.Enabled = true;
            }
            else
            {
                if (this.currentIndex < 1)
                {
                    btn_previous.Enabled = false;
                    btn_next.Enabled = true;
                }
                if (this.currentIndex >= this.maxQuestions - 1)
                {
                    btn_next.Enabled = false;
                    btn_previous.Enabled = true;
                }
            }
        }

        string CheckedAnswer()
        {
            answer = null;
            //ckb_choiceA.Checked ? answer = 'A' : null;
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

        void PreviouAnswers(string[] previousAnswers)
        {
            foreach (var item in previousAnswers)
            {
                if (item.Contains("a"))
                {
                    ckb_choiceA.Checked = true;
                }
                if (item.Contains("b"))
                {
                    ckb_choiceB.Checked = true;
                }
                if (item.Contains("c"))
                {
                    ckb_choiceC.Checked = true;
                }
                if (item.Contains("d"))
                {
                    ckb_choiceD.Checked = true;
                }
                if (item.Contains("e"))
                {
                    ckb_choiceE.Checked = true;
                }
                if (item.Contains("f"))
                {
                    ckb_choiceF.Checked = true;
                }
            }
        }

        void Timer()
        {
            int _time = this.time;

            testTime.Interval = (_time * 1000); // 10s current

        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            nav = true;

            answer = CheckedAnswer();

            try
            {
                NextQuestion?.Invoke(this, null);

                this.answers = this.previousAnswers;

                if (answers != null)
                {
                    this.PreviouAnswers(answers);

                    answers = null;
                }

                //if (this.currentIndex <= this.maxQuestions && this.currentIndex > 0)
                //{
                //    btn_next.Enabled = true;
                //    btn_previous.Enabled = true;
                //}
                //else
                //{
                //    if (this.currentIndex < 1)
                //    {
                //        btn_previous.Enabled = false;
                //        btn_next.Enabled = true;
                //    }
                //    if (this.currentIndex >= this.maxQuestions)
                //    {
                //        btn_next.Enabled = false;
                //        btn_previous.Enabled = true;
                //    }
                //}
                CheckIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            nav = true;

            answer = CheckedAnswer();

            try
            {
                PreviousQuestion?.Invoke(this, null);

                this.answers = this.previousAnswers;

                if (answers != null)
                {
                    this.PreviouAnswers(answers);

                    answers = null;
                }

                //if (this.currentIndex <= this.maxQuestions && this.currentIndex > 0)
                //{
                //    btn_next.Enabled = true;
                //    btn_previous.Enabled = true;
                //}
                //else
                //{
                //    if (this.currentIndex < 1)
                //    {
                //        btn_previous.Enabled = false;
                //        btn_next.Enabled = true;
                //    }
                //    if (this.currentIndex >= this.maxQuestions)
                //    {
                //        btn_next.Enabled = false;
                //        btn_previous.Enabled = true;
                //    }
                //}
                CheckIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        int IMainExamination.userID => this.userID;
        string IMainExamination.testID => this.examInfo;

        public string content { get => tb_content.Text; set => tb_content.Text = value; }
        public string choiceA { get => tb_a.Text; set => tb_a.Text = value; }
        public string choiceB { get => tb_b.Text; set => tb_b.Text = value; }
        public string choiceC { get => tb_c.Text; set => tb_c.Text = value; }
        public string choiceD { get => tb_d.Text; set => tb_d.Text = value; }
        public string choiceE { get => tb_e.Text; set => tb_e.Text = value; }
        public string choiceF { get => tb_f.Text; set => tb_f.Text = value; }
        string IMainExamination.answer => this.answer;
        int IMainExamination.currentIndex { set => this.currentIndex = value; }
        int IMainExamination.numberOfQuestion { set => this.maxQuestions = value; }
        int IMainExamination.examineeListID => this.examineeListID;
        string[] IMainExamination.previousAnswers { get => this.previousAnswers; set => this.previousAnswers = value; }

        public event EventHandler NextQuestion;
        public event EventHandler PreviousQuestion;
        public event EventHandler LoadQuestion;
        public event EventHandler Submit;
        public event EventHandler<SelectedChangedEventArgs> SelectedChangedQuestion;
    }
}
