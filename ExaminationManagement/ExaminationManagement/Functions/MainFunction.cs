using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationManagement.Functions
{
    public class MainFunction
    {
        public string[] SplitAnswerArray(string answer)
        {
            //answer = answer.Replace(" ", "");
            string[] answerArray = { "" };

            if (answer != null)
            {
                answerArray = null;
                
                answer = answer.Trim();

                char[] delimiterChars = { ' ', ',', '.', ':', '\t', '-', '/' };

                answerArray = answer.Split(delimiterChars);
            }

            return answerArray;
        }
    }
}
