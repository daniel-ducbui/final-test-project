using System;
using System.Collections.Generic;
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
    public interface ITheQuestion
    {
        object DataGridViewItems { get; set; }
        TextBox QuestionID { get; set; }
        TextBox QuestionLevel { get; set; }
        //TextBox QuestionType { get; set; }
        RichTextBox QuestionContent { get; set; }
        TextBox ChoiceA { get; set; }
        TextBox ChoiceB { get; set; }
        TextBox ChoiceC { get; set; }
        TextBox ChoiceD { get; set; }
        TextBox ChoiceE { get; set; }
        TextBox ChoiceF { get; set; }
        TextBox Answer { get; set; }

        event EventHandler NewQuestion;
        event EventHandler UpdateQuestion;
        event EventHandler DeleteQuestion;
        event EventHandler<SelectedChangedEventArgs> SelectedChangeQuestion;
    }
}
