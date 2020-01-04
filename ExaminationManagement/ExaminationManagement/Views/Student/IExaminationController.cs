using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Student
{
    interface IExaminationController
    {
        int userID { get; }
        object dataSource { get; set; }
        string testID { get; set; }
        int examID { get; }

        event EventHandler GetMainExamList;
        event EventHandler GetTestExamList;
        event EventHandler GetResult;
        event EventHandler GetExamInfo;
    }
}
