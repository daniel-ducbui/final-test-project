using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Teacher.TestController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Teacher.TestController
{
    class TestDetailsManagementPresenter
    {
        ITestListDetailsManagement view;
        BaseQuery baseQuery = new BaseQuery();
        List<string> testListIDList = new List<string>();

        int userID = 0;
        string testListID = null;

        public TestDetailsManagementPresenter(ITestListDetailsManagement testListDetailsManagement)
        {
            this.view = testListDetailsManagement;

            Initialize();
        }

        private void Initialize()
        {
            this.userID = view.userID;
            this.testListID = view.testListID;

            this.LoadData();
            view.Execute += View_Execute;
        }

        private void View_Execute(object sender, EventArgs e)
        {
            try
            {
                this.testListIDList = view.testListIDList;

                foreach (var item in this.testListIDList)
                {
                    baseQuery.ExecuteTestListDetails(this.testListID, item, view.signal);
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
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _testListDetails = (from tld in _data.TestListDetails
                                            where tld.TestListID == this.testListID
                                            select new { tld.TestListID, tld.TestID }).ToList();

                    var _theTests = (from t in _data.TheTests
                                     select t).ToList();

                    view.testListDetails = _testListDetails;
                    view.theTests = _theTests;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }
    }
}
