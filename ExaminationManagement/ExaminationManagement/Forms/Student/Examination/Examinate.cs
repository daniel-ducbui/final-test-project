using ExaminationManagement.Forms.CustomMessageBox;
using ExaminationManagement.Functions.Events;
using ExaminationManagement.Presenters.Student.Examination;
using ExaminationManagement.Views.Student.Examination;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Student.Examination
{
    public partial class Examinate : MaterialForm, IExaminate
    {
        ExaminatePresenter examinationPresenter;
        ExaminationControlPanel examinationControlPanel;
        int userID = 0;
        string username = null;
        int time = 0;
        int examinationID = 0;
        int examinationType = 0;
        string testID = null;
        string[] answers = null;
        string[] previousAnswers = null;
        string answer = null;
        bool nav = false;

        int flagChangeColor = 0;
        int flagSubmitted = 0;
        int flagForceSubmit = 0;
        int flagShowAllAnswers = 0;

        int m = 0, s = 0;

        int currentIndex = 0;
        int maxQuestions = 0;

        public Examinate()
        {
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Blue300, MaterialSkin.Primary.Blue500, 
                MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            InitializeComponent();

            Load += MainExamination_Load;
            btn_start.Click += Btn_start_Click;
            btn_next.Click += Btn_next_Click;
            btn_previous.Click += Btn_previous_Click;
            btn_submit.Click += Btn_submit_Click;
            btn_back.Click += Btn_back_Click;
            btn_showThisAnswer.Click += Btn_showThisAnswer_Click;
            btn_showAllAnswers.Click += Btn_showAllAnswers_Click;
        }

        private void MainExamination_Load(object sender, EventArgs e)
        {
            examinationPresenter = new ExaminatePresenter(this);

            // If not first enroll
            if (this.flagSubmitted == 1)
            {
                if (MessageBox.Show("Do you want to continue? \n\n-Yes to Continue \n-No to Start again?", "You have already enroll this test!", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    this.flagSubmitted = 0;
                }
            }

            if (btn_start.Enabled)
            {
                btn_next.Enabled
                    = btn_previous.Enabled
                    = btn_submit.Enabled
                    = btn_showThisAnswer.Enabled
                    = btn_showAllAnswers.Enabled
                    = false;
            }

            if (this.maxQuestions == 0)
            {
                if (MessageBox.Show(examinationPresenter.ErrorMessage, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();

                    examinationControlPanel = new ExaminationControlPanel(this.userID);
                    examinationControlPanel.Show();
                }
            }

            if (this.examinationType == 1)
            {
                this.panel2.Size = new System.Drawing.Size(202, 49);
                this.btn_showThisAnswer.Hide();
                this.btn_showAllAnswers.Hide();
            }

            tb_content.TextChanged += (s, ev) =>
            {
                if (nav)
                {
                    nav = false;
                }
            };

            this.lsc_info.Text = this.username;
            this.lsc_info.Info = Convert.ToString(this.userID);
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

        void OnChangeColor()
        {
            tb_a.BackColor = Color.Snow;
            tb_b.BackColor = Color.Snow;
            tb_c.BackColor = Color.Snow;
            tb_d.BackColor = Color.Snow;
            tb_e.BackColor = Color.Snow;
            tb_f.BackColor = Color.Snow;
        }

        void ShowAnswer()
        {
            try
            {
                ShowThisAnswer?.Invoke(this, null);

                this.flagChangeColor = 1;
                this.OnSetPreviousAnswer();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Something wrong! \nDetails: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Btn_showThisAnswer_Click(object sender, EventArgs e)
        {
            this.ShowAnswer();
        }

        private void Btn_showAllAnswers_Click(object sender, EventArgs e)
        {
            try
            {
                ShowAllAnswers?.Invoke(this, null);

                if (this.flagShowAllAnswers == 1)
                {
                    this.ShowAnswer();
                    btn_showThisAnswer.Enabled = false;
                    btn_showAllAnswers.BGColor = "#00cc1c";
                }
                else
                {
                    this.OnChangeColor();
                    btn_showThisAnswer.Enabled = true;
                    btn_showAllAnswers.BGColor = "#508ef5";
                }
                this.OnSetPreviousAnswer();
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Something wrong! \nDetails: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public Examinate(int userID, int examinationID, string testID) : this()
        {
            this.userID = userID;
            this.examinationID = examinationID;
            this.testID = testID;
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
                btn_next.Enabled
                    = btn_previous.Enabled
                    = btn_submit.Enabled
                    = btn_showThisAnswer.Enabled
                    = btn_showAllAnswers.Enabled
                    = true;

                this.LoadQuestions();
                this.SetQuestionIndex();

                // Millisecond to Minute:Second
                double _time = this.time * 1000 * 60;
                double _s = _time;

                this.m = (int)(_s / (60 * 1000));
                _s = _s % (60 * 1000);
                this.s = (int)(_s / 1000);

                // Start the timer
                testTimeLeft.Tick += OnTimedEvent;
                testTimeLeft.Start();

                this.OnSetPreviousAnswer();

                CheckIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        // Timer
        private void OnTimedEvent(object sender, EventArgs e)
        {
            int flagChangeColor = 0;

            testTimeLeft.Interval = 1000;

            Invoke(new Action(() =>
            {
                if (this.m == 0 && this.s == 0)
                {
                    tb_time.BackColor = System.Drawing.Color.Red;
                    flagChangeColor = 1;

                    testTimeLeft.Stop();

                    try
                    {
                        if (MessageBox.Show("Time Up", "Time is up!", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            this.flagForceSubmit = 2;
                            this.OnSubmit();
                        }
                    }
                    catch (Exception)
                    {
                        this.OnSubmit();
                    }
                }

                if (this.s == 0 && flagChangeColor == 0)
                {
                    this.s = 59;
                    this.m -= 1;
                }

                if (m != 0 || s != 0)
                {
                    this.s -= 1;
                }

                tb_time.Text = string.Format("{0}:{1}", this.m.ToString().PadLeft(2, '0'), this.s.ToString().PadLeft(2, '0'));
            }));

        }

        void SetQuestionIndex()
        {
            int _questionIndex = this.currentIndex;
            tb_questionIndex.Text = Convert.ToString(_questionIndex + 1);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            if (this.flagForceSubmit == 0)
            {
                if (MessageBox.Show("You have not submitted yet! ", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    testTimeLeft.Stop();
                    this.Close();

                    examinationControlPanel = new ExaminationControlPanel(this.userID);
                    examinationControlPanel.Show();
                }
            }
            else
            {
                testTimeLeft.Stop();
                this.Close();

                examinationControlPanel = new ExaminationControlPanel(this.userID);
                examinationControlPanel.Show();
            }
        }

        void OnSubmit()
        {
            this.flagForceSubmit = 1;

            answer = GetCheckedAnswer();

            Submit?.Invoke(this, null);

            if (this.flagForceSubmit == 3)
            {
                if (MessageBox.Show("You have not done the test! \nDo you want to submit anyway?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.flagForceSubmit = 2;

                    Submit?.Invoke(this, null);

                    testTimeLeft.Stop();

                    MessageBox.Show(examinationPresenter.ErrorMessage);

                    answer = null;

                    this.Close();

                    examinationControlPanel = new ExaminationControlPanel(this.userID);
                    examinationControlPanel.Show();
                }
            }
            else
            {
                MessageBox.Show(examinationPresenter.ErrorMessage);

                answer = null;

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
                    this.OnSubmit();
                    testTimeLeft.Stop();
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

        private void Btn_next_Click(object sender, EventArgs e)
        {
            nav = true;

            this.OnChangeColor();

            answer = GetCheckedAnswer();

            try
            {
                NextQuestion?.Invoke(this, null);

                this.SetQuestionIndex();

                if (this.flagShowAllAnswers == 1)
                {
                    this.ShowAnswer();
                }
                else
                {
                    this.OnSetPreviousAnswer();
                }

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

            this.OnChangeColor();

            answer = GetCheckedAnswer();

            try
            {
                PreviousQuestion?.Invoke(this, null);

                this.SetQuestionIndex();

                if (this.flagShowAllAnswers == 1)
                {
                    this.ShowAnswer();
                }
                else
                {
                    this.OnSetPreviousAnswer();
                }

                CheckIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong! \nDetails: " + ex.Message);
            }
        }

        int IExaminate.userID => this.userID;
        string IExaminate.username { get => this.username; set => this.username = value; }
        string IExaminate.testID => this.testID;
        int IExaminate.time { get => this.time; set => this.time = value; }
        int IExaminate.examinationID => this.examinationID;
        int IExaminate.examinationType { get => this.examinationType; set => this.examinationType = value; }

        public string content { get => tb_content.Text; set => tb_content.Text = value; }
        public string choiceA { get => tb_a.Text; set => tb_a.Text = value; }
        public string choiceB { get => tb_b.Text; set => tb_b.Text = value; }
        public string choiceC { get => tb_c.Text; set => tb_c.Text = value; }
        public string choiceD { get => tb_d.Text; set => tb_d.Text = value; }
        public string choiceE { get => tb_e.Text; set => tb_e.Text = value; }
        public string choiceF { get => tb_f.Text; set => tb_f.Text = value; }

        string IExaminate.answer => this.answer;
        int IExaminate.currentIndex { set => this.currentIndex = value; }
        int IExaminate.numberOfQuestion { set => this.maxQuestions = value; }
        string[] IExaminate.previousAnswers { get => this.previousAnswers; set => this.previousAnswers = value; }

        int IExaminate.flagShowAllAnswers { get => this.flagShowAllAnswers; set => this.flagShowAllAnswers = value; }
        int IExaminate.flagSubmitted { get => this.flagSubmitted; set => this.flagSubmitted = value; }
        int IExaminate.flagForceSubmit { get => this.flagForceSubmit; set => this.flagForceSubmit = value; }

        public event EventHandler NextQuestion;
        public event EventHandler PreviousQuestion;
        public event EventHandler LoadQuestion;
        public event EventHandler ShowThisAnswer;
        public event EventHandler ShowAllAnswers;
        public event EventHandler Submit;

        public event EventHandler<SelectedChangedEventArgs> SelectedChangedQuestion;
    }
}
