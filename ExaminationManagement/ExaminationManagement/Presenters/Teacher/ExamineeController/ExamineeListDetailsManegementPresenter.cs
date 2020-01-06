using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Teacher.ExamineeController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Teacher.ExamineeController
{
    class ExamineeListDetailsManegementPresenter
    {
        IExamineeListDetailsManagement view;
        BaseQuery baseQuery = new BaseQuery();
        List<int> examineeListIDList = new List<int>();

        int userID = 0;
        int examineeListID = 0;

        public ExamineeListDetailsManegementPresenter(IExamineeListDetailsManagement presenter)
        {
            this.view = presenter;

            Initialize();
        }

        private void Initialize()
        {
            this.LoadData();

            this.userID = view.userID;
            this.examineeListID = view.examineeListID;

            view.ExecuteExaminee += View_ExecuteExaminee;
        }

        private void View_ExecuteExaminee(object sender, EventArgs e)
        {
            try
            {
                this.examineeListIDList = view.examineeListIDList;

                foreach (var item in this.examineeListIDList)
                {
                    baseQuery.ExecuteExamineeListDetails(this.examineeListID, item, view.signal);
                }

                LoadData();

                view.errorMessage = baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }

        void LoadData()
        {
            try
            {
                this.examineeListID = view.examineeListID;

                using (var _data = new ExaminationManagementDataContext())
                {
                    var _examineeList = (from a in _data.Accounts
                                         join ad in _data.AccountDetails on a.UserID equals ad.UserID

                                         where a.Permission == 2
                                         && a.UserID == ad.UserID

                                         select new { a.UserID, ad.Name, ad.GradeID }).ToList();

                    var _examineeListDetails = (from exld in _data.ExamineeListDetails

                                         where exld.ExamineeListID == this.examineeListID

                                         select new { exld.ExamineeListID, exld.UserID }).ToList();

                    view.examineeList = _examineeList;
                    view.examineeListDetails = _examineeListDetails;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }
    }
}
