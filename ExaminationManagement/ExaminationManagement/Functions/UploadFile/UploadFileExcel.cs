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
                for (int i = 3; i < rowCount; i++)
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
                    baseQuery.AddAccount(Name, PhoneNumber, Email, _dob, Address, ClassID, GradeID, AccountType, _temp);

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