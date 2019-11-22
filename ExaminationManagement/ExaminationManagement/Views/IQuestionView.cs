using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views
{
    public class SelectedChangedEventArgs : EventArgs
    {
        public int Index { get; set; }
    }
    public interface IQuestionView
    {
        object DataGridViewItems { get; set; }
        TextBox questionID { get; set; }
        TextBox level { get; set; }
        RichTextBox content { get; set; }
        TextBox choiceA { get; set; }
        TextBox choiceB { get; set; }
        TextBox choiceC { get; set; }
        TextBox choiceD { get; set; }
        TextBox choiceE { get; set; }
        TextBox choiceF { get; set; }
        TextBox correctAnswer { get; set; }

        event EventHandler NewQuestion;
        event EventHandler UpdateQuestion;
        event EventHandler DeleteQuestion;
        event EventHandler<SelectedChangedEventArgs> SelectedChangeQuestion;
    }
}
