using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Student
{
    interface IQuestion
    {
        int userID { get; }
        int permission { get; set; }
        int questionID { get; }
        string content { get; set; }
        string choiceA { get; set; }
        string choiceB { get; set; }
        string choiceC { get; set; }
        string choiceD { get; set; }
        string choiceE { get; set; }
        string choiceF { get; set; }
        string answer { get; set; }
        object DataSource { get; set; }
        string errorMessage { get; set; }
        string[] previousAnswers { get; set; }
        string fileName { get; set; }

        event EventHandler LoadQuestion;
        event EventHandler AddQuestion;
        event EventHandler ShowQuestion;
        event EventHandler EditQuestion;
        event EventHandler ImportQuestion;
    }
}
