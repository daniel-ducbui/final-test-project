using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Password
{
    class ChangePasswordPresenter
    {
        IChangePassword view;
        Authentication authentication = new Authentication();

        string oldPassword = null;
        string newPassword = null;
        string confirmNewPassword = null;

        public ChangePasswordPresenter(IChangePassword changePassword)
        {
            this.view = changePassword;

            Initialize();
        }

        private void Initialize()
        {
            view.Confirm += View_Confirm;
        }

        private void View_Confirm(object sender, EventArgs e)
        {
            view.flagSuccess = false;

            this.oldPassword = view.oldPassword;
            this.newPassword = view.newPassword;
            this.confirmNewPassword = view.confirmNewPassword;

            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _user = _data.Accounts
                                .Where(a => a.UserID == view.userID).FirstOrDefault();

                    // Get old password
                    string _oldPassword = _user.Password.ToString();

                    // Encrypt new password
                    string _encryptNewPassword = authentication.Encrypt(this.newPassword);

                    // Decrypt password
                    string _decryptedPassword = authentication.Decrypt(this.oldPassword, _oldPassword);
                    if (_encryptNewPassword == _oldPassword)
                    {
                        view.errorMessage = "New password must different from old password!";
                    }
                    else
                    {
                        if (_oldPassword == _decryptedPassword)
                        {
                            if (this.newPassword == this.confirmNewPassword)
                            {
                                // Save new password to database

                                _user.Password = _encryptNewPassword;
                                _data.SubmitChanges();

                                view.errorMessage = "Password changed!";
                                view.flagSuccess = true;
                            }
                            else
                            {
                                view.errorMessage = "Confirm password is not matched";
                            }
                        }
                        else
                        {
                            view.errorMessage = "Wrong old password";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = "Something wrong! \nDetails: " + ex.Message;
            }
        }
    }
}
