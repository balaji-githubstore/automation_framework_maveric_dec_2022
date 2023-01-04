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


    }
}
