using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.TestController
{
    interface ITheTestManagement
    {
        int userID { get; }
        string errorMessage { get; set; }
        object testList { get; set; }
        //object testListDetails { get; set; }

        event EventHandler LoadQuestion;
    }
}
