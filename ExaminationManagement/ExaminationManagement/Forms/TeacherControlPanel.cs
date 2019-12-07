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
            InitializeComponent();
        }

        // NOTE: Khi sử dụng userID chỉ cần gọi this.userID

        public void GetUserID(int _userID)
        {
            this.userID = _userID;
        }
    }
}
