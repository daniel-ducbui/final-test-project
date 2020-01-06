using ExaminationManagement.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExaminationManagement.Functions.UploadFile
{
    public class UploadFileExcel
    {
        public string ErrorMessage = null;
        public void ReadData(string fileName)
        {
            // Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(fileName);
            Excel._Worksheet _worksheet = workbook.Sheets[1];
            Excel.Range range = _worksheet.UsedRange;

            BaseQuery baseQuery = new BaseQuery();

            try
            {
                int rowCount = range.Rows.Count;
                int columnCount = range.Columns.Count;

                int _AccountType = int.Parse(range.Cells[1, 1].Value2.ToString());

                string Name = null,
                    PhoneNumber = null,
                    Email = null,
                    DOB = null,
                    Address = null,
                    ClassID = "0",
                    temp = null;
                int AccountType = 0,
                    GradeID = 0;

                // Fetch every single row
                for (int i = 3; i <= rowCount; i++)
                {
                    Name = range.Cells[i, 1].Value2.ToString();
                    PhoneNumber = range.Cells[i, 2].Value2.ToString();
                    Email = range.Cells[i, 3].Value2.ToString();
                    DOB = range.Cells[i, 4].Value2.ToString();
                    Address = range.Cells[i, 5].Value2.ToString();

                    if (_AccountType == 2)
                    {
                        ClassID = range.Cells[i, 6].Value2.ToString();
                        GradeID = int.Parse(range.Cells[i, 7].Value2.ToString());
                    }
                    else
                    {
                        ClassID = "0";
                        GradeID = 0;
                    }
                    AccountType = _AccountType;

                    // Convert DateTime type after import
                    double date = double.Parse(DOB);
                    DateTime _dob = DateTime.FromOADate(date);

                    // Create a default password
                    temp = _dob.ToString("ddMM") + ClassID;
                    // Encrypt password
                    Authentication authentication = new Authentication();
                    string _temp = authentication.Encrypt(temp);

                    // Call add account function
                    baseQuery.ExecuteAccount(-1, Name, PhoneNumber, Email, _dob, Address, ClassID, GradeID, AccountType, _temp, -1);
                }
            }
            catch (Exception e)
            {
                ErrorMessage = "Fail! \nDetails: " + e.Message + "\n" + baseQuery.ErrorMessage;
            }
            // cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            // release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(_worksheet);

            // close and release
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            // quit and release
            application.Quit();
            Marshal.ReleaseComObject(application);
        }

        public void ReadQuestionData(string fileName, int UserID)
        {
            // Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Open(fileName);
            Excel._Worksheet _worksheet = workbook.Sheets[1];
            Excel.Range range = _worksheet.UsedRange;

            BaseQuery baseQuery = new BaseQuery();

            try
            {
                int rowCount = range.Rows.Count;
                int columnCount = range.Columns.Count;

                string content = null,
                    c1 = null,
                    c2 = null,
                    c3 = null,
                    c4 = null,
                    c5 = null,
                    c6 = null,
                    answer = null;
                int level = 0;

                // Fetch every single row
                for (int i = 3; i <= rowCount; i++)
                {
                    content = range.Cells[i, 1].Value2.ToString();
                    c1 = range.Cells[i, 2].Value2.ToString();
                    c2 = range.Cells[i, 3].Value2.ToString();
                    c3 = range.Cells[i, 4].Value2.ToString();
                    c4 = range.Cells[i, 5].Value2.ToString();
                    c5 = range.Cells[i, 6].Value2.ToString();
                    c6 = range.Cells[i, 7].Value2.ToString();
                    answer = range.Cells[i, 8].Value2.ToString();
                    level = Convert.ToInt32(range.Cells[i, 9].Value2.ToString());

                    // Call add account function
                    baseQuery.ExecuteQuestion(0, content, c1, c2, c3, c4, c5, c6, answer, level, 1, UserID, 1);
                }
            }
            catch (Exception e)
            {
                ErrorMessage = "Fail! \nDetails: " + e.Message + "\n" + baseQuery.ErrorMessage;
            }
            // cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            // release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(_worksheet);

            // close and release
            workbook.Close();
            Marshal.ReleaseComObject(workbook);

            // quit and release
            application.Quit();
            Marshal.ReleaseComObject(application);
        }
    }
}