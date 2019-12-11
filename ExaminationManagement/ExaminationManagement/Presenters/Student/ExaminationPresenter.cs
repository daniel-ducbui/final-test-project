using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement.Presenters
{
    public class ExaminationPresenter
    {
        IExamination view;
        List<TheQuestion> theQuestions;
        BindingSource bindingSource;
        public ExaminationPresenter(IExamination studentView)
        {
            view = studentView;

            Initialize();
        }
        private void Initialize()
        {
            view.LoadQuestion += View_LoadQuestion;
            view.ChooseAnswer += View_ChooseAnswer;
        }

        private void View_LoadQuestion(object sender, EventArgs e)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                bindingSource = new BindingSource();

                theQuestions = _data.TheQuestions.ToList();
                bindingSource.DataSource = theQuestions;
                view.questionContent.DataBindings.Add("Text", bindingSource, "QuestionContent");
                view.choiceA.DataBindings.Add("Text", bindingSource, "ChoiceA");
                view.choiceB.DataBindings.Add("Text", bindingSource, "ChoiceB");
                view.choiceC.DataBindings.Add("Text", bindingSource, "ChoiceC");
                view.choiceD.DataBindings.Add("Text", bindingSource, "ChoiceD");
                view.choiceE.DataBindings.Add("Text", bindingSource, "ChoiceE");
                view.choiceF.DataBindings.Add("Text", bindingSource, "ChoiceF");
            }
        }

        private void View_ChooseAnswer(object sender, EventArgs e)
        {
        }
    }
}
