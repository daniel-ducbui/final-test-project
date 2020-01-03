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
        string username { get; set; }
        string testID { get; }
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
        int examinationID { get; }
        int examinationType { get; set; }
        int time { get; set; }
        string[] previousAnswers { get; set; }

        int flagShowAllAnswers { get; set; }
        int flagSubmitted { get; set; }
        int flagForceSubmit { get; set; }

        event EventHandler NextQuestion;
        event EventHandler PreviousQuestion;
        event EventHandler ShowThisAnswer;
        event EventHandler ShowAllAnswers;
        event EventHandler LoadQuestion;
        event EventHandler Submit;
        event EventHandler<SelectedChangedEventArgs> SelectedChangedQuestion;
    }
}
