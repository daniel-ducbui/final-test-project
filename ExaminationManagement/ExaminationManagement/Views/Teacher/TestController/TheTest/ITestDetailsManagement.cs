using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.TestController.TheTest
{
    interface ITestDetailsManagement
    {
        int userID { get; }
        string testID { get; }
        string errorMessage { get; set; }
        object theQuestions { get; set; }
        object testDetails { get; set; }
        bool signal { get; set; }
        List<int> questionIDList { get; set; }

        event EventHandler ExecuteTest;
    }
}
