using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Functions.UploadFile;

namespace ExaminationManagement.Functions
{
    public class BaseQuery
    {
        public string ErrorMessage = null;
        public void AddAccount(string _Name, string _PhoneNumber, string _Email, DateTime _DOB, string _Address, string _ClassID, int _GradeID, int _AccountType, string _temp)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var newAccount = new AccountDetail
                    {
                        Name = _Name,
                        PhoneNumber = _PhoneNumber,
                        Email = _Email,
                        DOB = _DOB,
                        Address = _Address,
                        ClassID = _ClassID,
                        GradeID = _GradeID,
                        AccountType = _AccountType,
                        temp = _temp
                    };
                    _data.AccountDetails.InsertOnSubmit(newAccount);
                    _data.SubmitChanges();
                }
                ErrorMessage = "Success!";
            }                             
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
