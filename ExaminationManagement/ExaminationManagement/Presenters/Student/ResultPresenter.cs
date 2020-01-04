using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Student.Examination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Student
{
    class ResultPresenter
    {
        IResult view;

        public string ErrorMessage = null;

        public ResultPresenter(IResult result)
        {
            this.view = result;

            Initialize();
        }

        private void Initialize()
        {
            view.GetResultDetails += View_GetResultDetails;
        }

        private void View_GetResultDetails(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    // Get result details
                    var _getResultDetails = (from r in _data.Results
                                             join rd in _data.ResultDetails on r.ResultID equals rd.ResultID
                                             join a in _data.Accounts on r.UserID equals a.UserID
                                             join ad in _data.AccountDetails on a.UserID equals ad.UserID
                                             join q in _data.TheQuestions on rd.QuestionID equals q.QuestionID

                                             where
                                                r.UserID == a.UserID &&
                                                r.ResultID == rd.ResultID &&
                                                a.UserID == ad.UserID &&
                                                r.UserID == view.userID &&
                                                r.ResultID == view.resultID &&
                                                rd.QuestionID == q.QuestionID

                                             select new { QuestionID = rd.QuestionID, Your_Answer = rd.Answer, True_Answer = q.Answer, Score = rd.Score }).ToList();


                    // Get examination name
                    var _getInformation = (from r in _data.Results
                                           join a in _data.Accounts on r.UserID equals a.UserID
                                           join ad in _data.AccountDetails on a.UserID equals ad.UserID
                                           join t in _data.TheTests on r.TestID equals t.TestID
                                           join tld in _data.TestListDetails on t.TestID equals tld.TestID
                                           join tl in _data.TestLists on tld.TestListID equals tl.TestListID
                                           join ex in _data.TheExaminations on tl.TestListID equals ex.TestListID

                                           where
                                                r.ResultID == view.resultID &&
                                                r.ExaminationID == ex.ExaminationID &&
                                                a.UserID == view.userID

                                           select new { ex.ExaminationName, t.TestID, r.TotalScore, r.Times, ad.Name }).FirstOrDefault();

                    /// Tranfer to view
                    view.dataSource = _getResultDetails;
                    view.name = _getInformation.Name;
                    view.examinationName = _getInformation.ExaminationName;
                    view.testID = _getInformation.TestID;
                    view.times = _getInformation.Times;
                    view.totalScore = _getInformation.TotalScore;

                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }
    }
}
