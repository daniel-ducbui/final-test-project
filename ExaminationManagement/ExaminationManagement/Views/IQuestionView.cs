using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views
{
    public class SelectedChangedEventArgs : EventArgs
    {
        public int Index { get; set; }
    }
    public interface IQuestionView
    {


        //string level { get; set; }
        //string content { get; set; }
        //string choiceA { get; set; }
        //string choiceB { get; set; }
        //string choiceC { get; set; }
        //string choiceD { get; set; }
        //string choiceE { get; set; }
        //string choiceF { get; set; }
        //string correctAnswer { get; set; }
        DataTable dt
        {
            get; set;
        }

        event EventHandler NewQuestion;
        event EventHandler UpdateQuestion;
        event EventHandler DeleteQuestion;
        event EventHandler<SelectedChangedEventArgs> SelectedChangeQuestion;
    }
}
