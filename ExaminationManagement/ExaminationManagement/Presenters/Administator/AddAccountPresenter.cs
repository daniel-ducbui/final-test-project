using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Administator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Administator
{
    class AddAccountPresenter
    {
        IAddAccount view;
        Authentication authentication;

        public string ErrorMessage = null;

        public AddAccountPresenter(IAddAccount addAccount)
        {
            this.view = addAccount;

            Initialize();
        }

        private void Initialize()
        {
            view.AddUser += View_AddUser;
            view.Save += View_Save;

            if (view._userID != 0)
            {
                this.FindUser();
            }
        }

        void FindUser()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var _userDetails = (from a in _data.Accounts
                                    join ad in _data.AccountDetails on a.UserID equals ad.UserID

                                    where
                                        a.UserID == view._userID &&
                                        a.UserID == ad.UserID
                                    select ad).FirstOrDefault();

                view.name = _userDetails.Name;
                view.phoneNumber = _userDetails.PhoneNumber;
                view.email = _userDetails.Email;
                view.dob = Convert.ToString(_userDetails.DOB);
                view.address = _userDetails.Address;
                view.classID = _userDetails.ClassID;
                view.gradeID = Convert.ToString(_userDetails.GradeID);
                view.accountType = Convert.ToString(_userDetails.AccountType);
            }
        }

        void ExecuteUser(int _userID)
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
            string _temp = null;

            Name = view.name;
            PhoneNumber = view.phoneNumber;
            Email = view.email;
            DOB = view.dob;
            Address = view.address;
            ClassID = view.classID;
            GradeID = int.Parse(view.gradeID);
            AccountType = int.Parse(view.accountType);

            // Convert date
            DateTime _dob = DateTime.Parse(DOB);

            if (view._userID == 0)
            {
                temp = view.password;

                // Encrypt password - Main password
                authentication = new Authentication();
                _temp = authentication.Encrypt(temp);
            }

            BaseQuery baseQuery = new BaseQuery();

            try
            {
                // Insert to database
                baseQuery.ExecuteAccount(_userID, Name, PhoneNumber, Email, _dob, Address, ClassID, GradeID, AccountType, _temp);
                ErrorMessage = baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                ErrorMessage = "Something wrong. Please try again! \nDetails: " + ex.Message;
            }
        }

        private void View_Save(object sender, EventArgs e)
        {
            this.ExecuteUser(view._userID);
        }

        private void View_AddUser(object sender, EventArgs e)
        {
            this.ExecuteUser(view._userID);
        }
    }
}
