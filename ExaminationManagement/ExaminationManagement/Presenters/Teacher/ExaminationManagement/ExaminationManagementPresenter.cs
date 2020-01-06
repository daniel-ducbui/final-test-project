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
    class ExaminationManagementPresenter
    {
        IExaminationManagement view;

        int userID = 0;
        int examinationID = 0;

        public ExaminationManagementPresenter(IExaminationManagement examinationManagement)
        {
            this.view = examinationManagement;

            Initialize();
        }

        private void Initialize()
        {
            view.LoadData += View_LoadData;
            view.Delete += View_Delete;

            this.userID = view.userID;
            this.examinationID = view.examinationID;
        }

        void LoadData()
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _examinationList = (from ex in _data.TheExaminations
                                                //join tl in _data.TestLists on ex.TestListID equals tl.TestListID
                                                //join exl in _data.ExamineeLists on ex.ExamineeListID equals exl.ExamineeListID
                                                //join exld in _data.ExamineeListDetails on exl.ExamineeListID equals exld.ExamineeListID
                                                //join tld in _data.TestListDetails on tl.TestListID equals tld.TestListID

                                            select new
                                            {
                                                ex.ExaminationID,
                                                ex.ExaminationName,
                                                ex.TestListID,
                                                ex.ExamineeListID,
                                                ex.ExaminationType,
                                                ex.GradeID,
                                                ex.Time,
                                                ex.Creator,
                                                ex.CreateDate,
                                                ex.EndDate
                                            }).ToList();

                    view.dataSource = _examinationList;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }

        private void View_LoadData(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void View_Delete(object sender, EventArgs e)
        {
            try
            {
                BaseQuery baseQuery = new BaseQuery();

                baseQuery.ExecuteExamination(view.examinationID, null, 0, null, 0, 0, 0, 0, DateTime.Now, DateTime.Now, DateTime.Now, false);

                this.LoadData();

                view.errorMessage = baseQuery.ErrorMessage;
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
                throw;
            }
        }
    }
}
