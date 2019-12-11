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
    public class ProfilePresenter
    {
        IProfile view;
        List<AccountDetail> accountDetails;
        BindingSource bindingSource;
        public ProfilePresenter (IProfile profileView)
        {
            view = profileView;

            Initialize();
        }

        private void Initialize()
        {
            view.SaveProfile += View_SaveProfile;
            view.LoadProfile += View_LoadProfile;
        }

        private void View_LoadProfile(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var _userID = _data.AccountDetails.SingleOrDefault(x => x.UserID == view.userID);

                if (_userID != null)
                {
                    bindingSource = new BindingSource();

                    accountDetails = _data.AccountDetails.Where(x => x.UserID == view.userID).ToList();
                    bindingSource.DataSource = accountDetails;

                    view.name.DataBindings.Add("Text", bindingSource, "Name");
                    view.phoneNumber.DataBindings.Add("Text", bindingSource, "PhoneNumber");
                    view.email.DataBindings.Add("Text", bindingSource, "Email");

                    //CultureInfo cultureInfo = new CultureInfo("en-Eh");
                    //DateTime _dob = DateTime.ParseExact(view.dob.Text, "MM/dd/yyyy", cultureInfo, DateTimeStyles.None);

                    view.dob.DataBindings.Add("Text", bindingSource, "DOB");
                    view.address.DataBindings.Add("Text", bindingSource, "Address");
                    view.ClassID.DataBindings.Add("Text", bindingSource, "ClassID");
                    view.gradeID.DataBindings.Add("Text", bindingSource, "GradeID");
                }
            }
        }

        private void View_SaveProfile(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var profile = _data.AccountDetails.SingleOrDefault(x => x.UserID == view.userID);
                if (profile != null)
                {
                    profile.Name = view.name.Text;
                    profile.PhoneNumber = view.phoneNumber.Text;
                    profile.Email = view.email.Text;
                    //profile.DOB = DateTime.Parse(view.dob);
                    DateTime dateTime;
                    DateTime.TryParseExact(view.dob.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
                    profile.DOB = dateTime;

                    profile.Address = view.address.Text;
                    profile.ClassID = view.ClassID.Text;
                    profile.GradeID = Convert.ToInt32(view.gradeID.Text);
                }

                _data.SubmitChanges();
            }
        }
    }
}
