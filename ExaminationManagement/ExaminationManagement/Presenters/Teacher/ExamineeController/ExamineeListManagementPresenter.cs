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
    class ExamineeListManagementPresenter
    {
        IExamineeListManagement view;
        BaseQuery baseQuery = new BaseQuery();

        int userID = 0;

        public ExamineeListManagementPresenter(IExamineeListManagement examineeManagement)
        {
            this.view = examineeManagement;

            Initialize();
        }

        private void Initialize()
        {
            this.LoadData();

            this.userID = view.uesrID;
            view.Execute += View_Execute;
            view.ShowExaminee += View_ShowExaminee;
        }

        private void View_ShowExaminee(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _test = (from exl in _data.ExamineeLists
                                 where exl.ExamineeListID == view.examineeListID
                                 select exl).FirstOrDefault();

                    view.examineeListID = _test.ExamineeListID;
                    view.examineeName = _test.ExamineeListName;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }

        private void View_Execute(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = (from ex in _data.TheExaminations
                                    join exl in _data.ExamineeLists on ex.ExamineeListID equals exl.ExamineeListID

                                    where ex.ExamineeListID == exl.ExamineeListID
                                    && ex.ExamineeListID == view.examineeListID

                                    select ex).FirstOrDefault();

                    if (isExists == null)
                    {
                        baseQuery.ExecuteExamineeList(view.examineeListID, view.examineeName, view.signal);

                        view.errorMessage = baseQuery.ErrorMessage;
                    }
                    else
                    {
                        view.errorMessage = "The examinee list is being used!";
                    }
                }

                LoadData();
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
                    var _examineeListID = (from exl in _data.ExamineeLists
                                           select exl).ToList();

                    view.examineeList = _examineeListID;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }
    }
}
