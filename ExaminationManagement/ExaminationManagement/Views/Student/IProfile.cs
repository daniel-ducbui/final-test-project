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

        LollipopTextBox name { get; set; }

        LollipopTextBox phoneNumber { get; set; }

        LollipopTextBox email { get; set; }

        MaskedTextBox dob { get; set; }

        LollipopTextBox address { get; set; }

        LollipopTextBox classID { get; set; }

        LollipopTextBox gradeID { get; set; }

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
