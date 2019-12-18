using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views
{
    public interface IExamination
    {
        public class SelectedChangedEventArgs : EventArgs
        {
            public int index { get; set; }
        }
        string questionContent { get; set; }
        string choiceA { get; set; }
        string choiceB { get; set; }
        string choiceC { get; set; }
        string choiceD { get; set; }
        string choiceE { get; set; }
        string choiceF { get; set; }

        event EventHandler ChooseAnswer;
        event EventHandler NextQuestion;
        event EventHandler PrevQuestion;
        event EventHandler<SelectedChangedEventArgs> selectedChangedQuestion;
    }
}