using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher
{
    interface IStudentManager
    {
        int userID { get; }
        string errorMessage { get; set; }

        object dataSource { get; set; }
    }
}
