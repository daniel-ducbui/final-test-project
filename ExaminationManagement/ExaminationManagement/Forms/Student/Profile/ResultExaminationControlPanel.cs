using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Student.Profile
{
    public partial class ResultExaminationControlPanel : Form
    {
        StudentControlPanel studentControlPanel;
        public ResultExaminationControlPanel()
        {
            InitializeComponent();
            btn_back.Click += Btn_back_Click;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            studentControlPanel = new StudentControlPanel();
            studentControlPanel.FormClosed += (s, args) => this.Close();
            studentControlPanel.Show();
        }
    }
}
