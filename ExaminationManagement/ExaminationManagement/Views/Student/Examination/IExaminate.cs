using ExaminationManagement.Functions.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Student.Examination
{
    interface IExaminate
    {
        int userID { get; }
        string testID { get; }
        string testListID { get; }
        string content { get; set; }
        string choiceA { get; set; }
        string choiceB { get; set; }
        string choiceC { get; set; }
        string choiceD { get; set; }
        string choiceE { get; set; }
        string choiceF { get; set; }
        string answer { get; }
        int currentIndex { set; }
        int numberOfQuestion { set; }
        int examineeListID { get; }
        string[] previousAnswers { get; set; }

        event EventHandler NextQuestion;
        event EventHandler PreviousQuestion;
        event EventHandler LoadQuestion;
        event EventHandler Submit;
        event EventHandler<SelectedChangedEventArgs> SelectedChangedQuestion;
    }
}
