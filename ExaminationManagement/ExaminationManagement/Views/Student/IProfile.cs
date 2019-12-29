using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Student
{
    interface IProfile
    {
        int _userID { get; }

        TextBox name { get; set; }

        TextBox phoneNumber { get; set; }

        TextBox email { get; set; }

        MaskedTextBox dob { get; set; }

        TextBox address { get; set; }

        TextBox classID { get; set; }

        TextBox gradeID { get; set; }

        //string name { get; set; }

        //string phoneNumber { get; set; }

        //string email { get; set; }

        //string dob { get; set; }

        //string address { get; set; }

        //string classID { get; set; }

        //string gradeID { get; set; }

        event EventHandler LoadInfo;
        event EventHandler SaveInfo;
    }
}
