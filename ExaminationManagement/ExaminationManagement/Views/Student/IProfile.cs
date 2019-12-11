using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Student
{
    public interface IProfile
    {
        TextBox name { get; set; }
        TextBox phoneNumber { get; set; }
        TextBox email { get; set; }
        MaskedTextBox dob { get; set; }
        TextBox address { get; set; }
        TextBox ClassID { get; set; }
        TextBox gradeID { get; set; }

        int userID { get; }

        event EventHandler LoadProfile;
        event EventHandler SaveProfile;  
    }
}
