using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.ExamineeController
{
    interface IExamineeListManagement
    {
        int uesrID { get; }
        string errorMessage { get; set; }
        int examineeListID { get; set; }
        string examineeName { get; set; }
        object examineeList { get; set; }
        bool signal { get; set; }

        event EventHandler Execute;
        event EventHandler ShowExaminee;
    }
}
