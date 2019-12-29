using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationManagement.Functions.ConnectDatabase;
using ExaminationManagement.Functions.UploadFile;

namespace ExaminationManagement.Functions
{
    public class BaseQuery
    {
        public string ErrorMessage = null;
        public void ExecuteAccount(int _userID, string _Name, string _PhoneNumber,
            string _Email, DateTime _DOB, string _Address, string _ClassID, int _GradeID, int _AccountType, string _temp)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.AccountDetails.Where(a => a.UserID == _userID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newAccount = new AccountDetail
                        {
                            Name = _Name,
                            PhoneNumber = _PhoneNumber,
                            Email = _Email,
                            DOB = _DOB,
                            Address = _Address,
                            ClassID = _ClassID,
                            GradeID = _GradeID,
                            AccountType = _AccountType,
                            temp = _temp
                        };
                        _data.AccountDetails.InsertOnSubmit(newAccount);
                        _data.SubmitChanges();
                    }
                    else
                    {
                        isExists.Name = _Name;
                        isExists.PhoneNumber = _PhoneNumber;
                        isExists.Email = _Email;
                        isExists.DOB = _DOB;
                        isExists.Address = _Address;
                        isExists.ClassID = _ClassID;
                        isExists.GradeID = _GradeID;
                        _data.SubmitChanges();
                    }
                }
                ErrorMessage = "Success!";
            }
            catch (Exception e)
            {
                ErrorMessage = "Something wrong! \nDetails: \n- " + e.Message;
            }
        }

        public void ExecuteQuestion(int _questionID, string _Content, string _C1, string _C2, string _C3, string _C4, string _C5, string _C6,
            string _Answer, int _Level, int _Type, int _userID)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.TheQuestions.Where(q => q.QuestionID == _questionID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newQuestion = new TheQuestion
                        {
                            QuestionLevel = _Level,
                            QuestionType = _Type,
                            QuestionContent = _Content,
                            ChoiceA = _C1,
                            ChoiceB = _C2,
                            ChoiceC = _C3,
                            ChoiceD = _C4,
                            ChoiceE = _C5,
                            ChoiceF = _C6,
                            Answer = _Answer,
                            UserID = _userID,
                        };
                        _data.TheQuestions.InsertOnSubmit(newQuestion);
                        _data.SubmitChanges();
                    }
                    else
                    {
                        isExists.QuestionLevel = _Level;
                        isExists.QuestionType = _Type;
                        isExists.QuestionContent = _Content;
                        isExists.ChoiceA = _C1;
                        isExists.ChoiceB = _C2;
                        isExists.ChoiceC = _C3;
                        isExists.ChoiceD = _C4;
                        isExists.ChoiceE = _C5;
                        isExists.ChoiceF = _C6;
                        isExists.Answer = _Answer;
                        isExists.UserID = _userID;

                        _data.SubmitChanges();
                    }
                }
                ErrorMessage = "Success!";
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }

        public void SaveResult(int _resultID, int _userID, string _testID, int _totalScore)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var isExists = (from r in _data.Results
                                where r.ResultID == _resultID
                                select r).FirstOrDefault();

                if (isExists == null)
                {
                    var newResult = new Result
                    {
                        UserID = _userID,
                        TestID = _testID,
                        TotalScore = _totalScore,
                    };
                    _data.Results.InsertOnSubmit(newResult);
                    _data.SubmitChanges();
                }
                else
                {
                    isExists.TotalScore = _totalScore;
                    _data.SubmitChanges();
                }
            }
        }

        public void EnrollExamination(int _userID, int _examineeListID)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var isExists = (from exld in _data.ExamineeListDetails
                                where exld.UserID == _userID
                                where exld.ExamineeListID == _examineeListID
                                select exld).FirstOrDefault();

                if (isExists != null)
                {
                    int _status = isExists.Status;

                    if (_status == 0)
                    {
                        isExists.Status = 1;
                        _data.SubmitChanges();
                    }
                }
            }
        }

        public void SaveResultDetails(int _questionID, int _resultID, string _answer, int _score)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = (from r in _data.ResultDetails
                                    where r.ResultID == _resultID
                                    where r.QuestionID == _questionID
                                    select r).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newResult = new ResultDetail
                        {
                            QuestionID = _questionID,
                            ResultID = _resultID,
                            Answer = _answer,
                            Score = _score,
                        };
                        _data.ResultDetails.InsertOnSubmit(newResult);
                        _data.SubmitChanges();
                    }
                    else
                    {
                        isExists.Answer = _answer;
                        isExists.Score = _score;
                        _data.SubmitChanges();
                    }
                }
            }
            catch (Exception e)
            {
                this.ErrorMessage = e.Message;
            }
        }

        public int FindResult(int _userID, string _testID)
        {
            int resultID = 0;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _result = (from r in _data.Results
                               where r.UserID == _userID
                               where r.TestID == _testID
                               select r.ResultID).FirstOrDefault();

                if (_result != null)
                {
                    resultID = _result;
                }
            }

            return resultID;
        }

        public int TotalScore(int _resultID)
        {
            int totalScore = 0;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _totalScore = (from r in _data.Results
                                   where r.ResultID == _resultID
                                   select r.TotalScore).FirstOrDefault();

                if (_totalScore != null)
                {
                    totalScore = _totalScore;
                }
            }

            return totalScore;
        }

        public int Score(int _resultID, int _questionID)
        {
            int score = 0;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _score = (from r in _data.ResultDetails
                              where r.ResultID == _resultID
                              where r.QuestionID == _questionID
                              select r.Score).FirstOrDefault();

                if (_score != null)
                {
                    score = _score;
                }
            }

            return score;
        }

        public List<string[]> GetUserAnsweredList(int _resultID)
        {
            MainFunction mainFunction = new MainFunction();
            List<string> userAnsweredList = new List<string>(); // Answered in database
            List<string[]> userAnswersList = new List<string[]>(); // Answered splitted string list

            using (var _data = new ExaminationManagementDataContext())
            {
                userAnsweredList = (from rd in _data.ResultDetails
                                    where rd.ResultID == _resultID
                                    select rd.Answer).ToList();
            }

            if (userAnsweredList != null)
            {
                foreach (var item in userAnsweredList)
                {
                    string[] _temp = mainFunction.SplitAnswerArray(item);
                    userAnswersList.Add(_temp);
                }
            }

            return userAnswersList;
        }
    }
}
