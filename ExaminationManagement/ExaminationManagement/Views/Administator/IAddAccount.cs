using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Administator
{
    interface IAddAccount
    {
        int userID { get; set; }
        int _userID { get; set; }
        string name { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
        string dob { get; set; }
        string address { get; set; }
        string classID { get; set; }
        string gradeID { get; set; }
        string accountType { get; set; }
        string password { get; set; }

        event EventHandler AddUser;
        event EventHandler Save;
    }
}
