using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.ExaminationManagement
{
    interface IExecuteExamination
    {
        int userID { get; }
        int examinationID { get; }
        string errorMessage { get; set; }
        string testListID { get; set; }
        string examineeListID { get; set; }
        string examinationName { get; set; }
        string type { get; set; }
        string gradeID { get; set; }
        string time { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }

        object testListIDList { set; }
        object examineeListIDList { set; }

        event EventHandler Execute;
        event EventHandler LoadExamination;
    }
}
