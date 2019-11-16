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
        List<DataRow> accountList;
        DbDataAdapter dbDataAdapter;
        DataTable accounts;

        //int isMatched = -1; // Declare flag
        public string ErrorMessage;

        public LoginPresenter(ILogin loginView)
        {
            view = loginView; // Generate view

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                BaseConnection connection = new BaseConnection();

                // Declare database name
                string dbName = "ExaminationManagement";
                // Declare query string
                string sqlCommand = @"SELECT * FROM Account";

                // Get data adapter by calling DataAdapter method from BaseConnection class
                dbDataAdapter = connection.DataAdapter(sqlCommand, dbName);
                // Create a new data table - "Account" table in database
                accounts = new DataTable();
                // Fill table with data adapter
                dbDataAdapter.Fill(accounts);

                // Push data into list - only field that is existed in database
                accountList = (from account in accounts.AsEnumerable()
                               select account).ToList();
            }
            catch (Exception e)
            {
                ErrorMessage = "Connect failed \nError details: " + e.Message; // Rise the error
            }
        }

        public int Authenticating()
        {
            foreach (var _account in accountList)
            {
                // Get password in database
                string password = _account.Field<string>("password").ToString();
                // Get userID in database
                string userID = _account.Field<string>("userID").ToString();
                // Replace userID space
                string username_non_space = userID.Replace(" ", "");
                // Get account's permission
                string permission = _account.Field<string>("permission").ToString();

                int permission_in_int = -1;
                int.TryParse(permission, out permission_in_int);

                // Check if userID that user typed is matched userID in database
                if (username_non_space == view.userID)
                {
                    // Decrypt password user typed compare with password in database
                    string decryptedPassword = authentication.Decrypt(view.password, password);
                    // Check if password that user typed is matched password in database
                    if (decryptedPassword == password)
                    {
                        //isMatched = 0; // Flag: if all are matched
                        return permission_in_int; // Send flag sign
                    }
                    ErrorMessage = "Password wrong!"; // Rise error if password is not matched
                }
                else
                {
                    ErrorMessage = "Account do not exist!"; // Rise error if userID is not exists
                }
                // isMatched = 0; // Flag: if userID is not matched
            }

            return -1; // Send flag sign
        }
    }
}
