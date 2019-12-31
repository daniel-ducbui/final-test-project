using ExaminationManagement.Forms.Teacher;
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

namespace ExaminationManagement.Forms
{
    public partial class TeacherControlPanel : Form, IProfile
    {
        QuestionManagementControlPanel questionManagementControlPanel;
        ExamManagementControlPanel examManagementControlPanel;
        ManageTheListOfContestantsControlPanel manageTheListOfContestantsControlPanel;
        int userID;

        public TeacherControlPanel()
        {
            InitializeComponent();
            btn_questionManagement.Click += Btn_questionManagement_Click;
            btn_examManagement.Click += Btn_examManagement_Click;
            btn_manageTheListOfContestants.Click += Btn_manageTheListOfContestants_Click;
        }

        private void Btn_manageTheListOfContestants_Click(object sender, EventArgs e)
        {
            manageTheListOfContestantsControlPanel = new ManageTheListOfContestantsControlPanel(this.userID);
            manageTheListOfContestantsControlPanel.ShowDialog();
        }

        private void Btn_examManagement_Click(object sender, EventArgs e)
        {
            examManagementControlPanel = new ExamManagementControlPanel(this.userID);
            examManagementControlPanel.ShowDialog();
        }

        public TeacherControlPanel(int userID) : this()
        {
            this.userID = userID;
        }

            private void Btn_questionManagement_Click(object sender, EventArgs e)
        {
            questionManagementControlPanel = new QuestionManagementControlPanel(this.userID);
            questionManagementControlPanel.ShowDialog();
        }
        int IProfile.userID => this.userID;
    }
}
