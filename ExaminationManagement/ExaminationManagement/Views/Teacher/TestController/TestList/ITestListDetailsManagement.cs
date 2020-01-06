using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.TestController
{
    interface ITestListDetailsManagement
    {
        int userID { get; }
        string testListID { get; }
        object testListDetails { get; set; }
        object theTests { get; set; }
        string errorMessage { get; set; }
        List<string> testListIDList { get; set; }
        bool signal { get; set; }

        event EventHandler Execute;
    }
}
