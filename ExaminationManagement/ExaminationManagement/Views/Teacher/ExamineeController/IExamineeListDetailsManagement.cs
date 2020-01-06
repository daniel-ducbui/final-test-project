using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.ExamineeController
{
    interface IExamineeListDetailsManagement
    {
        int userID { get; }
        int examineeListID { get; }
        string errorMessage { get; set; }
        object examineeList { get; set; }
        object examineeListDetails { get; set; }
        bool signal { get; set; }
        List<int> examineeListIDList { get; set; }

        event EventHandler ExecuteExaminee;
    }
}
