using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Student
{
    class ExaminationControllerPresenter
    {
        IExaminationController view;
        public string ErrorMessage = null;

        public ExaminationControllerPresenter(IExaminationController examinationController)
        {
            this.view = examinationController;

            Initialize();
        }

        private void Initialize()
        {
            view.GetMainExamList += View_GetMainExamList;
            view.GetTestExamList += View_GetTestExamList;
            view.GetResult += View_GetResult;
            view.GetExamInfo += View_GetExamInfo;
        }

        private void View_GetExamInfo(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _examInfo = (from ex in _data.TheExaminations
                                     join tl in _data.TestLists on ex.TestListID equals tl.TestListID
                                     join tld in _data.TestListDetails on tl.TestListID equals tld.TestListID
                                     join t in _data.TheTests on tld.TestID equals t.TestID

                                     where tl.TestListID == ex.TestListID
                                        && ex.ExaminationID == view.examID
                                        && t.TestID == tld.TestID
                                        && t.TestID == view.testID


                                     select new { tld.TestID, ex.TestListID, ex.ExamineeListID, ex.Time }).FirstOrDefault();

                    string _testID = _examInfo.TestID.Replace(" ", "");
                    string _testListID = _examInfo.TestListID;

                    view.testID = _testID;
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        private void View_GetMainExamList(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    view.dataSource = null;
                    // Check if this user have in TheExamineeList
                    //var _isExists = (from exLiD in _data.ExamineeListDetails
                    //                where exLiD.UserID == view.userID
                    //                select exLiD.ExamineeListID).FirstOrDefault();

                    // Get that List ID
                    //var _getExamListID = (from e1 in _data.ExamineeLists
                    //                   where e1.ExamineeListID == _isExists
                    //                   select e1.ExamineeListID).FirstOrDefault();

                    //var _getExamListID = (from e1 in _data.ExamineeLists
                    //                      join e2 in _data.ExamineeListDetails on e1.ExamineeListID equals e2.ExamineeListID
                    //                      where e1.ExamineeListID == e2.ExamineeListID
                    //                      where e2.Status == 0
                    //                      select e1.ExamineeListID).FirstOrDefault();

                    // Get user's Grade
                    var _getUserGradeID = _data.AccountDetails.Where(a => a.UserID == view.userID).Select(a => a.GradeID).FirstOrDefault();

                    // Get the schedule
                    //var dataSource = (from ex in _data.TheExaminations
                    //                where ex.GradeID == _getUserGradeID
                    //                where ex.ExamineeListID == _getExamListID
                    //                select new { ex.ExaminationID, ex.ExaminationName, ex.GradeID, ex.StartDate, ex.EndDate, ex.TestLists[0].TestID }).ToList();
                    var _examList = (from ex in _data.TheExaminations
                                     join exld in _data.ExamineeListDetails on ex.ExamineeListID equals exld.ExamineeListID
                                     join tl in _data.TestLists on ex.TestListID equals tl.TestListID
                                     join tld in _data.TestListDetails on tl.TestListID equals tld.TestListID

                                     where ex.ExamineeListID == exld.ExamineeListID
                                     && exld.UserID == view.userID
                                     && exld.Status == 0
                                     && ex.ExaminationType == 1
                                     && ex.GradeID == _getUserGradeID

                                     //where tl.TestListID == ex.TestListID
                                     //where ex.ExamineeListID == _getExamListID
                                     //ex.TestLists[0].TestID

                                     select new { ex.ExaminationID, tld.TestID, ex.ExaminationName, ex.GradeID, ex.StartDate, ex.EndDate }).ToList();

                    view.dataSource = _examList;
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        private void View_GetTestExamList(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    view.dataSource = null;
                    // Get user's Grade
                    var _getUserGradeID = _data.AccountDetails.Where(a => a.UserID == view.userID).Select(a => a.GradeID).FirstOrDefault();

                    var _examList = (from ex in _data.TheExaminations
                                     join exld in _data.ExamineeListDetails on ex.ExamineeListID equals exld.ExamineeListID
                                     join tl in _data.TestLists on ex.TestListID equals tl.TestListID
                                     join tld in _data.TestListDetails on tl.TestListID equals tld.TestListID

                                     where ex.ExamineeListID == exld.ExamineeListID
                                     && exld.UserID == view.userID
                                     && exld.Status == 0
                                     && ex.ExaminationType == 2
                                     && ex.GradeID == _getUserGradeID

                                     select new { ex.ExaminationID, tld.TestID, ex.ExaminationName, ex.GradeID, ex.StartDate, ex.EndDate }).ToList();

                    view.dataSource = _examList;
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        private void View_GetResult(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    view.dataSource = null;
                    // Get results
                    var _result = (from r in _data.Results
                                   join a in _data.Accounts on r.UserID equals a.UserID
                                   join t in _data.TheTests on r.TestID equals t.TestID

                                   where r.UserID == a.UserID &&
                                   r.TestID == t.TestID &&
                                   a.UserID == view.userID
                                   
                                   select new { r.ResultID, r.ExaminationID, r.TestID, r.Times, r.TotalScore }).ToList();

                    view.dataSource = _result;
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }
    }
}
