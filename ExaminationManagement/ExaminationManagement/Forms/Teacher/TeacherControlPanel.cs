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
    public partial class TeacherControlPanel : Form
    {
        int userID;

        public TeacherControlPanel()
        {
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public TeacherControlPanel(int userID) : this()
        {
            this.userID = userID;
        }
    }
}
