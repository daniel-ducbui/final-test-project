using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Student
{
    public interface IAddQuestion
    {
        RichTextBox questionContent { get; set; }
        TextBox choiceA { get; set; }
        TextBox choiceB { get; set; }
        TextBox choiceC { get; set; }
        TextBox choiceD { get; set; }
        TextBox choiceE { get; set; }
        TextBox choiceF { get; set; }
        TextBox answer { get; set; }
        DataGridView dgvTheQuestion { get; set; }
        int userID { get; }

        event EventHandler LoadTheQuestion;
        event EventHandler SaveQuestion;
        event EventHandler UpdateQuestion;
    }
}
