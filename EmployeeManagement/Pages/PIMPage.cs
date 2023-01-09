using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class PIMPage
    {
        private IWebDriver driver;

        public PIMPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnAddEmployee()
        {
            driver.FindElement(By.LinkText("Add Employee")).Click();
        }
    }
}
