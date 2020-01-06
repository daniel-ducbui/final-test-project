using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.ExaminationManagement
{
    interface IExaminationManagement
    {
        int userID { get; }
        int examinationID { get; set; }
        object dataSource { get; set; }
        string errorMessage { get; set; }

        event EventHandler LoadData;
        event EventHandler Delete;
    }
}
