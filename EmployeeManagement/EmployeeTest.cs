using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeTest : AutomationWrapper
    {
        [Test,TestCaseSource(typeof(DataSource),nameof(DataSource.AddValidEmployeeData))]
        public void AddValidEmployeeTest(string username,string password,string firstName,string middleName,string lastName,string expectedEmpName)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.LinkText("Add Employee")).Click();

            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("middleName")).SendKeys(middleName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();


            string headerLocatorXpath = "//h6[contains(normalize-space(),'@@@@@')]";
            headerLocatorXpath = headerLocatorXpath.Replace("@@@@@",firstName );

            string actualEmpRecord = driver.FindElement(By.XPath(headerLocatorXpath)).Text;
            Assert.That(actualEmpRecord, Is.EqualTo(expectedEmpName));

        }

        //run above test with two test case 
//        admin, admin123, John, W, Wick, John Wick
//admin,admin123,Saul, g, goodman, Saul Goodman

    }
}
