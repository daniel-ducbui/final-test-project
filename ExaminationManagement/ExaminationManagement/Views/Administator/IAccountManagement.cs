using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views
{
    public interface IAccountManagement
    {
        int _userID { get; }
        string searchContent { get; set; }
        object DataSource { get; set; }
        string fileName { get; }
        string selectedTable { get; }  

        event EventHandler ImportUser;
        event EventHandler LoadData;
    }
}