using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Presenters
{
    public class QuestionPresenter
    {
        IQuestionView view;
        List<TheQuestion> questions;

        public QuestionPresenter(IQuestionView iq)
        {
            view = iq;
            Initializer();

        }

        private void Initializer()
        {
            Load();
            view.NewQuestion += View_NewQuestion;
            view.UpdateQuestion += View_UpdateQuestion;
            view.DeleteQuestion += View_DeleteQuestion;
        }

        private DataTable ConvertToDataTable(object lst)
        {
            throw new NotImplementedException();
        }

        private void View_DeleteQuestion(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_UpdateQuestion(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void View_NewQuestion(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            using (var examination = new ExaminationManagementDataContext())
            {
                questions = examination.TheQuestions.ToList();
                view.dt = new DataTable();
                view.dt = ConvertToDataTable(questions);
            }
        }
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }

   
}
