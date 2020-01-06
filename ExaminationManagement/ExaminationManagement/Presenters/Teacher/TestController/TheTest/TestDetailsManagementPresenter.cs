using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Teacher.TestController.TheTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Teacher.TestController.TheTest
{
    class TestDetailsManagementPresenter
    {
        ITestDetailsManagement view;
        BaseQuery baseQuery = new BaseQuery();
        List<int> questionIDList = new List<int>();

        int userID = 0;
        string testID = null;

        public TestDetailsManagementPresenter(ITestDetailsManagement testDetailsManagement)
        {
            this.view = testDetailsManagement;

            Initialize();
        }

        private void Initialize()
        {
            this.userID = view.userID;
            this.testID = view.testID;

            view.ExecuteTest += View_ExecuteTest;

            this.LoadData();
        }

        private void View_ExecuteTest(object sender, EventArgs e)
        {
            try
            {
                this.questionIDList = view.questionIDList;

                foreach (var item in this.questionIDList)
                {
                    baseQuery.ExecuteTheTestDetails(this.testID, item, view.signal);
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
                    var _theQuestions = _data.TheQuestions.Where(q => q.Status == 1)
                        .Select(q => new { q.QuestionID, q.QuestionContent, q.QuestionLevel })
                        .ToList();
                    var _testDetails = _data.TestDetails.Where(td => td.TestID == this.testID)
                        .Select(td => new { td.TestID, td.QuestionID})
                        .ToList();

                    view.theQuestions = _theQuestions;
                    view.testDetails = _testDetails;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }
    }
}
