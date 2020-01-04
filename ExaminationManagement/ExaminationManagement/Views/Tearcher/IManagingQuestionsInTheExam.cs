using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Tearcher
{
    public interface IManagingQuestionsInTheExam
    { 
        int userID { get; }
        DataGridView dgv_questionSection { get; set; }
        DataGridView dgv_examInformation { get; set; }
        DataGridView dgv_listOfAllTheQuestion { get; set; }
        TextBox txt_examPaperCode { get; set; }
        TextBox txt_examName { get; set; }

        event EventHandler CreateTest;
        event EventHandler Update;
        event EventHandler DeleteTheTest;
        event EventHandler AddTheQuestion;
        event EventHandler DeleteTheQuestion;
        event EventHandler LoadAllQuestion;
        event EventHandler LoadAllTheTest;
        event EventHandler LoadQuestionOfTheTest;
    }
}
