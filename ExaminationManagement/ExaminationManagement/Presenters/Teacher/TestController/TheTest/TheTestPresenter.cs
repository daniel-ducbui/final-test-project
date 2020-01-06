using ExaminationManagement.Functions;
using ExaminationManagement.Functions.ConnectDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Views.Teacher.TestController.TheTest
{
    class TheTestPresenter
    {
        ITheTestManagement view;
        BaseQuery baseQuery = new BaseQuery();

        public TheTestPresenter(ITheTestManagement theTest)
        {
            this.view = theTest;

            Initialize();
        }

        private void Initialize()
        {
            this.LoadData();
            view.Execute += View_Execute;
            view.ShowTest += View_ShowTest;
        }

        private void View_ShowTest(object sender, EventArgs e)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _test = (from t in _data.TheTests
                                 where t.TestID == view.testID
                                 select t).FirstOrDefault();

                    view.testID = _test.TestID;
                    view.testName = _test.TestName;
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
                baseQuery.ExecuteTheTest(view.testID, view.testName, view.signal);

                view.errorMessage = baseQuery.ErrorMessage;

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
                    var _theTests = (from t in _data.TheTests
                                     select t).ToList();

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
