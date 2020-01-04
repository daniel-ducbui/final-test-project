using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Password
{
    interface IChangePassword
    {
        int userID { get; }
        string oldPassword { get; set; }
        string newPassword { get; set; }
        string confirmNewPassword { get; set; }
        string errorMessage { get; set; }
        bool flagSuccess { get; set; }

        event EventHandler Confirm;
    }
}
