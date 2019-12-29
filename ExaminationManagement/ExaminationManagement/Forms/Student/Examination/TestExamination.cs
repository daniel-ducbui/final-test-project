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
    public partial class TestExamination : Form
    {
        public TestExamination()
        {
            InitializeComponent();
        }
        
        int userID;

        public TestExamination(int userID) : this()
        {
            this.userID = userID;
        }
    }
}
