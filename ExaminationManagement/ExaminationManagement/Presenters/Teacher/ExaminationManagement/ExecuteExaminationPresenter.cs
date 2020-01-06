using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Teacher.ExaminationManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Teacher.ExaminationManagement
{
    class ExecuteExaminationPresenter
    {
        IExecuteExamination view;
        BaseQuery baseQuery = new BaseQuery();
        List<TheExamination> examination;

        int userID = 0;
        int examinationID = 0;

        string testListID = null,
            examinationName = null;
        int examineeListID = 0,
            type = 0,
            gradeID = 0,
            time = 0;
        DateTime createDate = DateTime.Now,
            startDate = DateTime.Now,
            endDate = DateTime.Now;

        public ExecuteExaminationPresenter(IExecuteExamination executeExamination)
        {
            this.view = executeExamination;

            Initialize();
        }

        private void Initialize()
        {
            view.Execute += View_Execute;

            this.userID = view.userID;
            this.examinationID = view.examinationID;

            this.GetInformation();
            if (this.examinationID != 0)
            {
                this.SetData();
            }
        }

        void GetInformation()
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _testListID = (from tl in _data.TestLists
                                       select tl.TestListID).ToList();

                    var _examineeListID = (from exl in _data.ExamineeLists
                                           select exl.ExamineeListID).ToList();

                    view.testListIDList = _testListID;
                    view.examineeListIDList = _examineeListID;

                    if (this.examinationID != 0)
                    {
                        var _examination = (from ex in _data.TheExaminations
                                            where ex.ExaminationID == this.examinationID
                                            select ex).ToList();

                        examination = new List<TheExamination>();
                        examination = _examination;
                    }
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }

        void GetData()
        {
            this.examinationName = view.examinationName;
            this.testListID = Convert.ToString(view.testListID);
            this.examineeListID = Convert.ToInt32(view.examineeListID);
            this.type = Convert.ToInt32(view.type);
            this.gradeID = Convert.ToInt32(view.gradeID);
            this.time = Convert.ToInt32(view.time);
            this.startDate = view.startDate;
            this.endDate = view.endDate;
        }

        void SetData()
        {
            view.examinationName = examination.Select(e => e.ExaminationName).FirstOrDefault();
            view.testListID = examination.Select(e => e.TestListID).FirstOrDefault();
            view.examineeListID = Convert.ToString(examination.Select(e => e.ExamineeListID).FirstOrDefault());
            view.type = Convert.ToString(examination.Select(e => e.ExaminationType).FirstOrDefault());
            view.gradeID = Convert.ToString(examination.Select(e => e.GradeID).FirstOrDefault());
            view.time = Convert.ToString(examination.Select(e => e.Time).FirstOrDefault());
            view.startDate = Convert.ToDateTime(examination.Select(e => e.StartDate).FirstOrDefault());
            view.endDate = Convert.ToDateTime(examination.Select(e => e.EndDate).FirstOrDefault());
        }

        private void View_Execute(object sender, EventArgs e)
        {
            try
            {
                this.GetData();

                baseQuery.ExecuteExamination(examinationID, testListID, examineeListID, examinationName, type, gradeID,
                    time, this.userID, createDate, startDate, endDate, true);

                view.errorMessage = baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }
    }
}
