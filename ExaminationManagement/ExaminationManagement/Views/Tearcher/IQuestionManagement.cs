using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Tearcher
{
    public interface IQuestionManagement
    {
        int userID { get; }
        DataGridView dgvTheQuestion { get; set; }
        TextBox questionLevel { get; set; }
        ComboBox questionType { get; set; }
        RichTextBox questionContent { get; set; }
        TextBox choiceA { get; set; }
        TextBox choiceB { get; set; }
        TextBox choiceC { get; set; }
        TextBox choiceD { get; set; }
        TextBox choiceE { get; set; }
        TextBox choiceF { get; set; }
        TextBox answer { get; set; }
        Button addQuestion { get; set; }
        Button saveChange { get; set; }
        Button deleteQuestion { get; set; }
        Button inportExcel { get; set; }
        Button browserQuestion { get; set; }

        event EventHandler LoadTheQuestion;
        event EventHandler AddQuestion;
        event EventHandler SaveChange;
        event EventHandler DeleteQuestion;
        event EventHandler InportExcel;
        event EventHandler BrowserQuestion;
    }
}
