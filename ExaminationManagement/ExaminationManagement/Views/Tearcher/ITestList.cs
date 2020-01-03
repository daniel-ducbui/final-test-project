using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Tearcher
{
    public interface ITestList
    {
        int userID { get; }
        DataGridView dgv_allTheTest { get; set; }
        DataGridView dgv_partOfTheExam { get; set; }
        DataGridView dgv_listOfAllExamQuestions { get; set; }
        TextBox txt_testID { get; set; }
        TextBox txt_testName { get; set; }

        event EventHandler CreateTheTest;
        event EventHandler Update;
        event EventHandler Delete;
        event EventHandler AddTheTest;
        event EventHandler DeleteTheTest;
        event EventHandler LoadAllTheTest;
        event EventHandler LoadTheTestOfTestList;
        event EventHandler LoadAllTestList;
    }
}
