using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Student
{
    public interface IAddQuestion
    {
        string questionContent { get; set; }
        string choiceA { get; set; }
        string choiceB { get; set; }
        string choiceC { get; set; }
        string choiceD { get; set; }
        string choiceE { get; set; }
        string choiceF { get; set; }
        string answer { get; set; }
        int userID { get; }

        event EventHandler SaveQuestion;
    }
}
