using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views
{
    public interface IAccountManagement
    {
        string searchContent { get; set; }
        string name { get; set; }
        string phoneNumber { get; set; }
        string email { get; set; }
        string dob { get; set; }
        string address { get; set; }
        string classID { get; set; }
        string gradeID { get; set; }
        string accountType { get; }
        string password { get; set; }
        object DataSource { get; set; }

        event EventHandler AddUser;
        event EventHandler EditUser;
        event EventHandler ImportUser;
        event EventHandler LoadData;
    }
}