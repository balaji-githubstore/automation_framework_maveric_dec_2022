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


            object[] allData = new object[3];

            for (int r = 2; r <= 4; r++)
            {
                //create string[]
                for (int c = 1; c <= 3; c++)
                {
                    string value = range.Cell(r, c).GetString();
                    Console.WriteLine(value);
                }

                //load string[] to object[]
               
            }

            book.Dispose();

            //make sure object[] is ready with all test case
        }
    }
}
