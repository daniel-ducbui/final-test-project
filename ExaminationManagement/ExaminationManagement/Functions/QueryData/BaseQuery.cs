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

        MainFunction mainFunction = new MainFunction();
        public string ErrorMessage = null;

        public void ExecuteAccount(int _userID, string _Name, string _PhoneNumber,
            string _Email, DateTime _DOB, string _Address, string _ClassID, int _GradeID, int _AccountType, string _temp, int _Permission)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.AccountDetails.Where(a => a.UserID == _userID).FirstOrDefault();
                    var permission = _data.Accounts.Where(a => a.UserID == _userID).FirstOrDefault();

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
                        isExists.AccountType = _AccountType;
                        permission.Permission = _Permission;
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
            string _Answer, int _Level, int _Type, int _userID, int _Status)
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
                            Status = _Status,
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

        // Execute examination
        public void ExecuteExamination(int _examinationID, string _testListID, int _examineeListID, string _examinatinName, int _examinationType,
            int _gradeID, int _time, int _creator, DateTime _createDate, DateTime _startDate, DateTime _endDate, bool _signal)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.TheExaminations.Where(e => e.ExaminationID == _examinationID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newExamination = new TheExamination
                        {
                            TestListID = _testListID,
                            ExamineeListID = _examineeListID,
                            ExaminationName = _examinatinName,
                            ExaminationType = _examinationType,
                            GradeID = _gradeID,
                            Time = _time,
                            Creator = _creator,
                            CreateDate = _createDate,
                            StartDate = _startDate,
                            EndDate = _endDate,
                        };

                        _data.TheExaminations.InsertOnSubmit(newExamination);
                    }
                    else
                    {
                        if (!_signal)
                        {
                            _data.TheExaminations.DeleteOnSubmit(isExists);
                        }
                        else
                        {
                            isExists.TestListID = _testListID;
                            isExists.ExamineeListID = _examineeListID;
                            isExists.ExaminationName = _examinatinName;
                            isExists.ExaminationType = _examinationType;
                            isExists.GradeID = _gradeID;
                            isExists.Time = _time;
                            isExists.Creator = _creator;
                            isExists.CreateDate = _createDate;
                            isExists.StartDate = _startDate;
                            isExists.EndDate = _endDate;
                        }
                    }

                    _data.SubmitChanges();
                }
                this.ErrorMessage = "Success!";
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        // For create, edit and delete The test
        public void ExecuteTheTest(string _testID, string _testName, bool _signal)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.TheTests.Where(t => t.TestID == _testID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newTest = new TheTest
                        {
                            TestID = _testID,
                            TestName = _testName,
                        };

                        _data.TheTests.InsertOnSubmit(newTest);
                    }
                    else
                    {
                        if (!_signal) // Delete
                        {
                            _data.TheTests.DeleteOnSubmit(isExists);
                        }
                        else
                        {
                            isExists.TestID = _testID;
                            isExists.TestName = _testName;
                        }
                    }

                    _data.SubmitChanges();
                }

                this.ErrorMessage = "Success!";
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        // For add, edit, delete question in The test
        public void ExecuteTheTestDetails(string _testID, int _questionID, bool _signal)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.TestDetails.Where(td => td.TestID == _testID && td.QuestionID == _questionID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newTestDetail = new TestDetail
                        {
                            TestID = _testID,
                            QuestionID = _questionID,
                        };

                        _data.TestDetails.InsertOnSubmit(newTestDetail);
                    }
                    else
                    {
                        if (!_signal)
                        {
                            _data.TestDetails.DeleteOnSubmit(isExists);
                        }
                        else
                        {
                            isExists.TestID = _testID;
                            isExists.QuestionID = _questionID;
                        }
                    }

                    _data.SubmitChanges();
                }

                this.ErrorMessage = "Success!";
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        // For create, edit and delete Test list
        public void ExecuteTestList(string _testListID, string _testListName, bool _signal)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.TestLists.Where(tl => tl.TestListID == _testListID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newTestList = new TestList
                        {
                            TestListID = _testListID,
                            TestListName = _testListName,
                        };

                        _data.TestLists.InsertOnSubmit(newTestList);
                    }
                    else
                    {
                        if (!_signal)
                        {
                            _data.TestLists.DeleteOnSubmit(isExists);
                        }
                        else
                        {
                            isExists.TestListID = _testListID;
                            isExists.TestListName = _testListName;
                        }
                    }

                    _data.SubmitChanges();
                }

                this.ErrorMessage = "Success!";
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        // For add, edit and delete Test List Details
        public void ExecuteTestListDetails(string _testListID, string _testID, bool _signal)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.TestListDetails.Where(tld => tld.TestListID == _testListID && tld.TestID == _testID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newTestListDetail = new TestListDetail
                        {
                            TestListID = _testListID,
                            TestID = _testID,
                        };

                        _data.TestListDetails.InsertOnSubmit(newTestListDetail);
                    }
                    else
                    {
                        if (!_signal)
                        {
                            _data.TestListDetails.DeleteOnSubmit(isExists);
                        }
                        else
                        {
                            isExists.TestListID = _testListID;
                            isExists.TestID = _testID;
                        }
                    }

                    _data.SubmitChanges();
                }

                this.ErrorMessage = "Success!";
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        // For add, edit and delete Examinee list
        public void ExecuteExamineeList(int _examineeListID, string _examineeListName, bool _signal)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.ExamineeLists.Where(exl => exl.ExamineeListID == _examineeListID).FirstOrDefault();

                    if (isExists == null)
                    {
                        var newExamineeList = new ExamineeList
                        {
                            ExamineeListName = _examineeListName,
                        };

                        _data.ExamineeLists.InsertOnSubmit(newExamineeList);
                    }
                    else
                    {
                        if (!_signal)
                        {
                            _data.ExamineeLists.DeleteOnSubmit(isExists);
                        }
                        else
                        {
                            isExists.ExamineeListName = _examineeListName;
                        }
                    }

                    _data.SubmitChanges();

                    this.ErrorMessage = "Success!";
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        public void ExecuteExamineeListDetails(int _examineeListID, int _userID, bool _signal)
        {
            try
            {
                using (var _data = new ExaminationManagementDataContext())
                {
                    var isExists = _data.ExamineeListDetails.Where(exld => exld.ExamineeListID == _examineeListID && exld.UserID == _userID).FirstOrDefault();
                    //int i = 0;

                    if (isExists == null)
                    {
                        var newExamineeListDetail = new ExamineeListDetail
                        {
                            ExamineeListID = _examineeListID,
                            UserID = _userID,
                        };

                        _data.ExamineeListDetails.InsertOnSubmit(newExamineeListDetail);
                    }
                    else
                    {
                        if (!_signal)
                        {
                            _data.ExamineeListDetails.DeleteOnSubmit(isExists);
                        }
                        else
                        {
                            isExists.ExamineeListID = _examineeListID;
                            isExists.UserID = _userID;
                            //i++;
                            //this.ErrorMessage = i + " User existed!";
                        }
                    }

                    _data.SubmitChanges();

                    this.ErrorMessage = "Success!";
                }
            }
            catch (Exception ex)
            {
                this.ErrorMessage = ex.Message;
            }
        }

        // Calculate total score
        public int TotalScore(int _resultID)
        {
            int score = 0;

            using (var _data = new ExaminationManagementDataContext())
            {
                var isExists = (from r in _data.Results
                                where r.ResultID == _resultID
                                select r).FirstOrDefault();

                if (isExists != null)
                {
                    var _resultDetails = (from rd in _data.ResultDetails
                                          where rd.ResultID == _resultID && rd.Score == 1
                                          select rd).ToList();

                    score = _resultDetails.Count();
                    this.ErrorMessage = "Success!";
                }
            }

            return score;
        }

        public void SaveResult(int _resultID, int _userID, string _testID, int _totalScore, int _times, int _isSubmitted, int _examinationID)
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
                        Times = _times,
                        IsSubmitted = _isSubmitted,
                        ExaminationID = _examinationID,
                    };
                    _data.Results.InsertOnSubmit(newResult);
                    _data.SubmitChanges();
                }
                else
                {
                    isExists.TotalScore = _totalScore;
                    isExists.IsSubmitted = _isSubmitted;
                    _data.SubmitChanges();
                }
                this.ErrorMessage = "Success!";
            }
        }

        public void EnrollExamination(int _userID, int _examineeListID, int _status)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var isExists = (from exld in _data.ExamineeListDetails

                                where
                                    exld.UserID == _userID &&
                                    exld.ExamineeListID == _examineeListID

                                select exld).FirstOrDefault();

                if (isExists != null)
                {
                    isExists.Status = _status;
                    _data.SubmitChanges();

                    this.ErrorMessage = "Success!";
                }
                else
                {
                    this.ErrorMessage = "Fail!";
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

        public int FindResult(int _userID, string _testID, string _testListID, int _examinationID)
        {
            int resultID = 0;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _result = (from r in _data.Results
                               join t in _data.TheTests on r.TestID equals t.TestID
                               join td in _data.TestDetails on t.TestID equals td.TestID
                               join tld in _data.TestListDetails on t.TestID equals tld.TestID
                               join tl in _data.TestLists on tld.TestListID equals tl.TestListID
                               join ex in _data.TheExaminations on tld.TestListID equals ex.TestListID

                               where
                                    r.UserID == _userID &&
                                    r.TestID == _testID &&
                                    r.TestID == td.TestID &&
                                    td.TestID == t.TestID &&
                                    t.TestID == tld.TestID &&
                                    tld.TestListID == tl.TestListID &&
                                    tl.TestListID == ex.TestListID &&
                                    ex.TestListID == _testListID &&
                                    ex.ExaminationID == _examinationID
                               orderby r.ResultID descending

                               select r.ResultID).FirstOrDefault();

                if (_result != null)
                {
                    resultID = _result;
                    this.ErrorMessage = "Success!";
                }
            }

            return resultID;
        }

        public bool IsSubmitted(int _resultID)
        {
            using (var _data = new ExaminationManagementDataContext())
            {
                var _isSubmitted = (from r in _data.Results
                                    where r.ResultID == _resultID
                                    select r.IsSubmitted).FirstOrDefault();

                if (_isSubmitted == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int FindTimes(int _resultID)
        {
            int times = 0;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _times = (from r in _data.Results
                              where r.ResultID == _resultID
                              select r.Times).FirstOrDefault();

                times = _times;
            }

            return times;
        }

        public int GetNumberOfQuestion(string _testID)
        {
            int number = 0;

            using (var _data = new ExaminationManagementDataContext())
            {
                var isExists = (from r in _data.TheTests
                                where r.TestID == _testID
                                select r).FirstOrDefault();

                if (isExists != null)
                {
                    var _number = (from td in _data.TestDetails
                                   where td.TestID == _testID
                                   select td).ToList();

                    number = _number.Count();
                    this.ErrorMessage = "Success!";
                }
            }

            return number;
        }

        // Get total score
        public int GetTotalScore(int _resultID)
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
                    this.ErrorMessage = "Success!";
                }
            }

            return totalScore;
        }

        public List<string[]> GetUserAnsweredList(int _resultID)
        {
            List<string[]> userAnswersList = new List<string[]>(); // Answered splitted string list

            using (var _data = new ExaminationManagementDataContext())
            {
                var _userAnsweredList = (from rd in _data.ResultDetails
                                         where rd.ResultID == _resultID
                                         select rd.Answer).ToList();

                if (_userAnsweredList != null)
                {
                    foreach (var item in _userAnsweredList)
                    {
                        string[] _temp = mainFunction.SplitAnswerArray(item);
                        userAnswersList.Add(_temp);
                    }

                    this.ErrorMessage = "Success!";
                }
            }

            return userAnswersList;
        }

        public List<string[]> GetTrueAnswersList(string _testID, int _questionID)
        {
            List<string[]> trueAnswersList = new List<string[]>();
            string[] _temp = null;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _trueAnswer = (from td in _data.TestDetails
                                   join q in _data.TheQuestions on td.QuestionID equals q.QuestionID

                                   where
                                        td.QuestionID == q.QuestionID &&
                                        td.TestID == _testID &&
                                        q.QuestionID == _questionID

                                   select q.Answer).FirstOrDefault();

                if (_trueAnswer != null)
                {
                    _temp = mainFunction.SplitAnswerArray(_trueAnswer);
                    trueAnswersList.Add(_temp);
                }
            }

            return trueAnswersList;
        }

        // For question control panel
        public List<TheQuestion> GetQuestion(int _questionID)
        {
            List<TheQuestion> theQuestions = new List<TheQuestion>();

            using (var _data = new ExaminationManagementDataContext())
            {
                var _question = (from q in _data.TheQuestions
                                 where q.QuestionID == _questionID
                                 select q).ToList();

                if (_question != null)
                {
                    theQuestions = _question;
                }
            }

            return theQuestions;
        }

        public int GetUserPermission(int _userID)
        {
            int permission = -1;

            using (var _data = new ExaminationManagementDataContext())
            {
                var _permission = (from a in _data.Accounts
                                   where a.UserID == _userID
                                   select a.Permission).FirstOrDefault();

                permission = _permission;
            }

            return permission;
        }
    }
}
