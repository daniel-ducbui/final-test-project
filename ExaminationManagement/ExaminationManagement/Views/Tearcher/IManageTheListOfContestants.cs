using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Views.Tearcher
{
    public interface IManageTheListOfContestants
    {
        int userID { get; }
        DataGridView dgv_allOfStudents { get; set; }
        DataGridView dgv_partListCandidates { get; set; }
        DataGridView dgv_listOfContestants { get; set; }
        TextBox txt_listingCode { get; set; }
        TextBox txt_listName { get; set; }

        event EventHandler CreateList;
        event EventHandler Update;
        event EventHandler DeleteTheTest;
        event EventHandler AddStudent;
        event EventHandler DeleteStudent;
        event EventHandler LoadAllExamineeList;
        event EventHandler LoadStudentOfExamineeList;
        event EventHandler LoadAllStudent;
    }
}
