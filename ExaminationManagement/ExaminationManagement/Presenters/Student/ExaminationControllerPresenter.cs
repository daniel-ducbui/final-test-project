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

        public ExaminationControllerPresenter(IExaminationController examinationController)
        {
            this.view = examinationController;

            Initialize();
        }

        private void Initialize()
        {
            view.GetExamList += View_GetExamList;
            view.GetExamInfo += View_GetExamInfo;
        }

        private void View_GetExamInfo(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var _examInfo = (from ex in _data.TheExaminations
                                join t in _data.TestLists 
                                on ex.TestListID equals t.TestListID
                                    where t.TestListID == ex.TestListID
                                    where ex.ExaminationID == view.examID
                                    select new { t.TestID, ex.ExamineeListID, ex.Time }).FirstOrDefault();

                string _testID = _examInfo.TestID.Replace(" ", "");
                int _examineeID = Convert.ToInt32(_examInfo.ExamineeListID);
                int _time = _examInfo.Time;

                view.testID = _testID;
                view.examineeListID = _examineeID;
                view.time = _time;
            }
        }

        private void View_GetExamList(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
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
                //var examList = (from ex in _data.TheExaminations
                //                where ex.GradeID == _getUserGradeID
                //                where ex.ExamineeListID == _getExamListID
                //                select new { ex.ExaminationID, ex.ExaminationName, ex.GradeID, ex.StartDate, ex.EndDate, ex.TestLists[0].TestID }).ToList();
                var _examList = (from ex in _data.TheExaminations
                                join exld in _data.ExamineeListDetails on ex.ExamineeListID equals exld.ExamineeListID
                                //join tl in _data.TestLists on ex.TestListID equals tl.TestListID

                                where ex.ExamineeListID == exld.ExamineeListID
                                where exld.UserID == view.userID
                                where exld.Status == 0
                                //where tl.TestListID == ex.TestListID
                                //where ex.GradeID == _getUserGradeID
                                //where ex.ExamineeListID == _getExamListID

                                select new { ex.ExaminationID, ex.ExaminationName, ex.GradeID, ex.StartDate, ex.EndDate, ex.TestLists[0].TestID }).ToList();

                view.examList = _examList;
            }
        }
    }
}
