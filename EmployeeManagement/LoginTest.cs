using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Base;
using EmployeeManagement.Utilities;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
        [Test,Retry(2)]
        public void ValidLoginTest()
        {
           
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }

        [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData2))]
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
