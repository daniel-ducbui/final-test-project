using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Student.Examination
{
    interface IResult
    {
        int userID { get; }
        int resultID { get; }
        int totalScore { get; set; }
        string name { get; set; }
        string examinationName { get; set; }
        string testID { get; set; }
        int times { get; set; }
        object dataSource { get; set; }

        event EventHandler GetResultDetails;
    }
}
