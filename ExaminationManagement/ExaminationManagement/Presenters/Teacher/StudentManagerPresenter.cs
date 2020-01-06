using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views.Teacher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters.Teacher
{
    class StudentManagerPresenter
    {
        IStudentManager view;

        int userID = 0;
        
        public StudentManagerPresenter(IStudentManager studentManager)
        {
            this.view = studentManager;

            Initialize();
        }

        private void Initialize()
        {
            this.LoadData();
        }

        void LoadData()
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var _studentList = (from a in _data.AccountDetails
                                        where a.AccountType == 2
                                        select new { a.UserID, a.Name, a.GradeID, a.ClassID, a.DOB }).ToList();

                    view.dataSource = _studentList;
                }
            }
            catch (Exception ex)
            {
                view.errorMessage = ex.Message;
            }
        }
    }
}
