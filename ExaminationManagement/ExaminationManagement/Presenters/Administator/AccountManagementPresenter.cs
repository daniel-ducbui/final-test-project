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
    }
}