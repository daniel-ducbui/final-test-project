using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Student;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Presenters.Student
{
    class ProfilePresenter
    {
        IProfile view;
        BindingSource bindingSource;
        List<AccountDetail> accountDetails;
        BaseQuery baseQuery;
        public string ErrorMessage = null;

        public ProfilePresenter(IProfile profileView)
        {
            view = profileView;

            Initialize();
        }

        private void Initialize()
        {
            view.LoadInfo += View_LoadInfo;
            view.SaveInfo += View_SaveInfo;
        }

        private void View_LoadInfo(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                bindingSource = new BindingSource();
                accountDetails = _data.AccountDetails.Where(a => a.UserID == view._userID).ToList();
                bindingSource.DataSource = accountDetails;

                view.name.DataBindings.Add("text", bindingSource, "Name");
                view.phoneNumber.DataBindings.Add("text", bindingSource, "PhoneNumber");
                view.email.DataBindings.Add("text", bindingSource, "Email");
                view.dob.DataBindings.Add("Text", bindingSource, "DOB");
                view.address.DataBindings.Add("text", bindingSource, "Address");
                view.classID.DataBindings.Add("text", bindingSource, "ClassID");
                view.gradeID.DataBindings.Add("text", bindingSource, "GradeID");
            }
        }

        private void View_SaveInfo(object sender, EventArgs e)
        {
            try
            {
                baseQuery = new BaseQuery();

                string Name = null,
                    PhoneNumber = null,
                    Email = null,
                    Address = null,
                    ClassID = "0";
                int GradeID = 0;
                DateTime DOB;

                Name = view.name.Text;
                PhoneNumber = view.phoneNumber.Text;
                Email = view.email.Text;

                DateTime dateTime = DateTime.ParseExact(view.dob.Text, "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                DOB = dateTime;
                Address = view.address.Text;
                ClassID = view.classID.Text;
                GradeID = Convert.ToInt32(view.gradeID.Text);

                baseQuery.ExecuteAccount(view._userID, Name, PhoneNumber, Email, DOB, Address, ClassID, GradeID, 0, null);
                this.ErrorMessage= baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                this.ErrorMessage = "Something wrong. Please try again! \nDetails: " + baseQuery.ErrorMessage + "\n" + ex.Message;
            }
        }
    }
}
