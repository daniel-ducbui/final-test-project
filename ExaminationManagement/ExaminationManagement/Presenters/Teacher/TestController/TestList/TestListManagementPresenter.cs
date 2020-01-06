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
    class TestListManagementPresenter
    {
        ITestListManagement view;
        BaseQuery baseQuery = new BaseQuery();

        int userID;

        public TestListManagementPresenter(ITestListManagement theTestManagement)
        {
            this.view = theTestManagement;

            Initialize();
        }

        private void Initialize()
        {
            this.userID = view.userID;

            LoadData();
            view.Execute += View_Execute;
            view.ShowTestList += View_ShowTestList;
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

                                     select new { tl.TestListID, tl.TestListName }).ToList();

                    view.testList = _testList;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = "Something wrong! \nDetails: " + ex.Message;
            }
        }

        private void View_ShowTestList(object sender, EventArgs e)
        {
            this.SetData();
        }

        void SetData()
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _testList = _data.TestLists.Where(tl => tl.TestListID == view.testListID).FirstOrDefault();

                    view.testListID = _testList.TestListID;
                    view.testListName = _testList.TestListName;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = baseQuery.ErrorMessage;
            }
        }

        private void View_Execute(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(view.testListID) && !string.IsNullOrEmpty(view.testListName))
                {
                    using (var _data = new ExaminationManagementDataContext())
                    {
                        var isExists = (from tl in _data.TestLists
                                        join ex in _data.TheExaminations on tl.TestListID equals ex.TestListID

                                        where tl.TestListID == ex.TestListID
                                            && tl.TestListID == view.testListID

                                        select tl).FirstOrDefault();

                        if (view.signal)
                        {
                            baseQuery.ExecuteTestList(view.testListID, view.testListName, true);

                            view.errorMessage = baseQuery.ErrorMessage;
                        }
                        else
                        {
                            if (isExists != null)
                            {
                                view.errorMessage = "Can not detele! Test list is being used";
                            }
                            else
                            {
                                baseQuery.ExecuteTestList(view.testListID, view.testListName, false);

                                view.errorMessage = baseQuery.ErrorMessage;
                            }
                        }
                    }

                    LoadData();
                }
                else
                {
                    view.errorMessage = "Fill all fields!";
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }
    }
}
