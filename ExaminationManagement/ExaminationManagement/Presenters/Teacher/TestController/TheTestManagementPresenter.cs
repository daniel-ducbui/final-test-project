using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Teacher.TestController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Teacher.TestController
{
    class TheTestManagementPresenter
    {
        ITheTestManagement view;

        int userID;

        public TheTestManagementPresenter(ITheTestManagement theTestManagement)
        {
            this.view = theTestManagement;

            Initialize();
        }

        private void Initialize()
        {
            this.userID = view.userID;

            LoadData();
        }

        void LoadData()
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _questionList = _data.TheQuestions.Where(q => q.Status == 1 && q.QuestionType == 1)
                        .Select(q => new { q.QuestionID, q.QuestionContent, q.QuestionLevel, q.Answer })
                        .ToList();
                    var _testList = (from tl in _data.TestLists
                                            //join tld in _data.TestListDetails on tl.TestListID equals tld.TestListID

                                            //where tl.TestListID == tld.TestListID

                                            select new { tl.TestListID, tl.TestListName }).ToList();

                    //
                    //var _testList = (from t in _data.TheTests
                    //                 //join td in _data.TestDetails on t.TestID equals td.TestID

                    //                 //where t.TestID == td.TestID

                    //                 select new { t.TestID, t.TestName }).ToList();

                    view.testList = _testList;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = "Something wrong! \nDetails: " + ex.Message;
            }
        }
    }
}
