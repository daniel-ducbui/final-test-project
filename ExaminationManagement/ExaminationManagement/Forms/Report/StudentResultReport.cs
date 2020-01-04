using ExaminationManagement.Forms.Student;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Forms.Report
{
    public partial class StudentResultReport : MaterialForm
    {
        public StudentResultReport()
        {
            InitializeComponent();

            btn_back.Click += Btn_back_Click;
        }

        int userID;
        int resultID;
        
        public StudentResultReport(int userID, int resultID) : this()
        {
            this.userID = userID;
            this.resultID = resultID;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            ResultControlPanel resultControlPanel = new ResultControlPanel(this.userID, this.resultID);
            resultControlPanel.Show();
        }
    }
}
