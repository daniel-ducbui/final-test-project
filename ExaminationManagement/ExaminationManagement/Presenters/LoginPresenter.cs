using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters
{
    public class LoginPresenter
    {
        ILogin view;
        Authentication authentication = new Authentication();

        public string ErrorMessage;

        public LoginPresenter(ILogin loginView)
        {
            view = loginView;
        }
        public int Authenticating()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                try
                {
                    // Get dataSet
                    var _account = _data.Accounts
                                        .Where(a => a.Username.ToString() == view.username).FirstOrDefault();
                    // Get password in database
                    string password = _account.Password.ToString();
                    // Get account's permission
                    int permission = Int32.Parse(_account.Permission.ToString());

                    // NOTE: we're not check Username because it had already check when query data

                    // Decrypt password user typed compare with password in database
                    string decryptedPassword = authentication.Decrypt(view.password, password);
                    // Check if password that user typed is matched password in database
                    if (decryptedPassword == password)
                    {
                        // Get current user id
                        view.userID = Convert.ToInt32(_account.UserID);

                        return permission; // Return permission if all are matched
                    }
                    ErrorMessage = "Password wrong!"; // Rise error if password is not matched
                }
                catch (NullReferenceException)
                {
                    ErrorMessage = "Account does not exist!";
                }
                return -1; // Return -1 if username does not exist
            }
        }
    }
}
