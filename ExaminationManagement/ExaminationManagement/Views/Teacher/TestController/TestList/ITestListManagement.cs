using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.TestController
{
    interface ITestListManagement
    {
        int userID { get; }
        string errorMessage { get; set; }
        object testList { get; set; }
        string testListID { get; set; }
        string testListName { get; set; }
        bool signal { get; set; }

        event EventHandler Execute;
        event EventHandler ShowTestList;
    }
}
