using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.TestController.TheTest
{
    interface ITheTestManagement
    {
        int userID { get; }
        string errorMessage { get; set; }
        string testID { get; set; }
        string testName { get; set; }
        object theTests { get; set; }
        bool signal { get; set; }

        event EventHandler Execute;
        event EventHandler ShowTest;
    }
}
