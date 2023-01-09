using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class AddEmployeePage
    {
        private IWebDriver driver;

        public AddEmployeePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterFirstName(string firstName)
        {
            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
        }
        public void EnterMiddleName(string middleName)
        {
            driver.FindElement(By.Name("firstName")).SendKeys(middleName);
        }

        public void EnterLastName(string lastName)
        {
            driver.FindElement(By.Name("firstName")).SendKeys(lastName);
        }

        public void ClickOnSave()
        {
            driver.FindElement(By.XPath("//button[normalize-space()='Save']")).Click();
        }
    }
}
