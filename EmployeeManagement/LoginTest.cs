using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Base;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {

        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }


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

            object[] allDataSets=new object[2];

            allDataSets[0] = dataSet1;
            allDataSets[1] = dataSet2;

            return allDataSets;
        }

        [Test,TestCaseSource(nameof(InvalidLoginData))]
        //[TestCase("john", "john123", "Invalid credential")]
        //[TestCase("peter", "peter233", "Invalid credential")]
        //[TestCase("saul", "saul123", "Invalid credential")]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
            Console.WriteLine(actualError.ToUpper());

            //Assert the error message Invalid credentials
            Assert.That(actualError.Contains(expectedError), "Assertion on error message");
        }
    }
}
