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
        RichTextBox questionContent { get; set; }
        CheckBox choiceA { get; set; }
        CheckBox choiceB { get; set; }
        CheckBox choiceC { get; set; }
        CheckBox choiceD { get; set; }
        CheckBox choiceE { get; set; }
        CheckBox choiceF { get; set; }
        string answer { get; set; }

        event EventHandler LoadQuestion;
        event EventHandler ChooseAnswer;
    }
}