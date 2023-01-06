using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace EmployeeManagement
{
    //will be deleted
    public class Demo3Excel
    {

        [Test]
        public void DemoExcelRead()
        {
            XLWorkbook book = new XLWorkbook(@"C:\Mine\Company\Maveric C# 2022\AutomationFramework\EmployeeManagement\TestData\orange_data.xlsx");

            IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");

            IXLRange range = sheet.RangeUsed();

            
            object[] allData = new object[2];

            for (int r = 2; r <= 3; r++)
            {
                //array for one test case//one row
                string[] arr = new string[3];

                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                    arr[c-1] = value;
                }

                //load string[] to object[]
                allData[r-2] = arr;
            }

            book.Dispose();

            //make sure object[] is ready with all test case
        }

        [Test]
        public void Demo2ExcelWrite()
        {
            using (XLWorkbook book = new XLWorkbook(@"C:\Mine\Company\Maveric C# 2022\AutomationFramework\EmployeeManagement\TestData\orange_data.xlsx"))
            {
                IXLWorksheet sheet = book.Worksheet("InvalidLoginTest");

                IXLRange range = sheet.RangeUsed();

                int rowCount = range.RowCount();
                int columnCount = range.ColumnCount();

                object[] allData = new object[rowCount - 1];

                for (int r = 2; r <= rowCount; r++)
                {
                    string[] arr = new string[3];

                    for (int c = 1; c <= columnCount; c++)
                    {
                        string value = range.Cell(r, c).GetString();
                        Console.WriteLine(value);
                        arr[c - 1] = value;
                    }
                    allData[r - 2] = arr;
                }
                
            }

        }
    }
}
