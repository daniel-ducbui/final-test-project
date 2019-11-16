using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views
{
    public interface ILogin
    {
        string userID { get; }
        string password { get; }
        bool isMatched { get; set; }
    }
}
