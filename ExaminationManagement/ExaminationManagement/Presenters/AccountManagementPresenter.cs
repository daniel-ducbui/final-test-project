using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Functions.UploadFile;
using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters
{
    public class AccountManagementPresenter
    {
        IAccountManagement view;
        Authentication authentication;

        public string ErrorMessage = null;

        public AccountManagementPresenter(IAccountManagement accountView)
        {
            view = accountView;

            Initialize();
        }

        private void Initialize()
        {
            view.LoadData += View_LoadData;
            view.AddUser += View_AddUser;
            view.EditUser += View_EditUser;
            view.ImportUser += View_ImportUser;
        }

        private void LoadData()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                if (view.selectedTable == "0")
                {
                    var accountList = (from a in _data.Accounts
                                       select new { a.UserID, a.Username, a.RegistryDate }).ToList();
                    view.DataSource = accountList;
                }
                else
                {
                    var accountList = (from a in _data.AccountDetails
                                       select new { a.UserID, a.Name, a.PhoneNumber, a.Email, a.DOB, a.Address, a.ClassID, a.GradeID, a.AccountType }).ToList();
                    view.DataSource = accountList;
                }
            }
        }

        private void View_LoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        private void View_ImportUser(object sender, EventArgs e)
        {
            UploadFileExcel uploadFile = new UploadFileExcel();
            string fileName = view.fileName;
            uploadFile.ReadData(fileName);

            ErrorMessage = uploadFile.ErrorMessage;
            LoadData();
        }

        private void View_EditUser(object sender, EventArgs e)
        {

        }

        private void View_AddUser(object sender, EventArgs e)
        {
            string Name = null,
                PhoneNumber = null,
                Email = null,
                DOB = null,
                Address = null,
                ClassID = "0",
                temp = null;
            int AccountType = 0,
                GradeID = 0;

            Name = view.name;
            PhoneNumber = view.phoneNumber;
            Email = view.email;
            DOB = view.dob;
            Address = view.address;
            ClassID = view.classID;
            GradeID = int.Parse(view.gradeID);
            AccountType = int.Parse(view.accountType);
            temp = view.password;

            // Convert date
            DateTime _dob = DateTime.Parse(DOB);

            // Encrypt password - Main password
            authentication = new Authentication();
            string _temp = authentication.Encrypt(temp);

            BaseQuery baseQuery = new BaseQuery();

            try
            {
                // Insert to database
                baseQuery.AddAccount(Name, PhoneNumber, Email, _dob, Address, ClassID, GradeID, AccountType, _temp);
                ErrorMessage = baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                ErrorMessage = "Something wrong. Please try again! \nDetails: " + ex.Message;
            }
            LoadData();
        }
    }
}