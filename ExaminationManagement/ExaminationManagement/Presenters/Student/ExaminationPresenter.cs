using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        int currentIndex = 0;
        public ExaminationPresenter(IExamination studentView)
        {
            view = studentView;
            Initialize();
        }
        private void Initialize()
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                theQuestions = _data.TheQuestions.ToList();
            }
            view.NextQuestion += View_NextQuestion;
            view.PrevQuestion += View_PrevQuestion;
            view.selectedChangedQuestion += View_selectedChangedQuestion;
            if(theQuestions.Count > 0)
            {
                string answer = loadQuestion();
                ChooseAnswer(answer);
            }
        }

        private void ChooseAnswer(string answer)
        {
            MessageBox.Show(view.choiceA + view.choiceB + view.choiceC + view.choiceD + view.choiceE + view.choiceF);
            //try
            //{
            //    var theTestDetails = new TheTestDetail
            //    {
            //        TestID = "0",
            //        Answer = 
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Fail! \n" + ex);
            //}
        }

        private void View_NextQuestion(object sender, EventArgs e)
        {
            string x = loadQuestion();
            ChooseAnswer(x);
            if (currentIndex < theQuestions.Count - 1)
            {
                currentIndex++;
                loadQuestion();
            }
        }
        private void View_PrevQuestion(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                loadQuestion();
            }
        }

        private void View_selectedChangedQuestion(object sender, IExamination.SelectedChangedEventArgs e)
        {
            if (e.index > -1)
            {
                currentIndex = e.index;
                loadQuestion();
            }
        }

        private string loadQuestion()
        {
            var theQuestion = theQuestions[currentIndex];
            view.questionContent = theQuestion.QuestionContent;
            view.choiceA = theQuestion.ChoiceA;
            view.choiceB = theQuestion.ChoiceB;
            view.choiceC = theQuestion.ChoiceC;
            view.choiceD = theQuestion.ChoiceD;
            view.choiceE = theQuestion.ChoiceE;
            view.choiceF = theQuestion.ChoiceF;
            return theQuestion.Answer;

        }
    }
}
