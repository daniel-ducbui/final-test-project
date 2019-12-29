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
        object examList { get; set; }
        string testID { get; set; }
        int examID { get; }
        int time { get; set; }
        int examineeListID { get; set; }

        event EventHandler GetExamList;
        event EventHandler GetExamInfo;
    }
}
