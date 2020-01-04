using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Tearcher
{
    public interface IExamManagement
    {
        int userID { get; }
        TextBox txt_examName { get; set; }
        ComboBox ccb_kindOfExam { get; set; }
        ComboBox ccb_selectTheExamList { get; set; }
        ComboBox ccb_chooseTheTestSet { get; set; }
        ComboBox ccb_chooseGrade { get; set; }
        MaskedTextBox mtb_startDay { get; set; }
        MaskedTextBox mtb_endDay { get; set; }
        TextBox txt_time { get; set; }
        DataGridView dgv_allExams { get; set; }

        event EventHandler CreateExam;
        event EventHandler CreateExamList;
        event EventHandler CreateTheExamSet;
        event EventHandler Update;
        event EventHandler Delete;
        event EventHandler SeeTheListOfExaminee;
        event EventHandler SeeTheResult;

        event EventHandler ComboboxOnlySelect;
        event EventHandler LoadAllExamination;
        event EventHandler LoadAllExamineeList;
        event EventHandler LoadAllTestList;
    }
}
