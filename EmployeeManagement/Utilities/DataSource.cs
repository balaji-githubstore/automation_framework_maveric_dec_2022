using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class DataSource
    {
        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[3];
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid credential";

            string[] dataSet2 = new string[3];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";
            dataSet2[2] = "Invalid credential";

            object[] allDataSets = new object[2];

            allDataSets[0] = dataSet1;
            allDataSets[1] = dataSet2;

            return allDataSets;
        }


        public static object[] AddValidEmployeeData()
        {
            string[] dataSet1 = new string[6];
            dataSet1[0] = "Admin";
            dataSet1[1] = "admin123";
            dataSet1[2] = "john";
            dataSet1[3] = "jj";
            dataSet1[4] = "wick";
            dataSet1[5] = "john wick";

            string[] dataSet2 = new string[6];
            dataSet2[0] = "Admin";
            dataSet2[1] = "admin123";
            dataSet2[2] = "saul";
            dataSet2[3] = "g";
            dataSet2[4] = "goodman";
            dataSet2[5] = "saul goodman";

            object[] allData = new object[2];
            allData[0] = dataSet1;
            allData[1] = dataSet2;

            return allData;
        }

        //run above test with two test case 
        //        admin, admin123, John, W, Wick, John Wick
        //admin,admin123,Saul, g, goodman, Saul Goodman

    }
}


























