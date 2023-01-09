using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class PersonalDetailsPage
    {
        private IWebDriver driver;

        public PersonalDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetAddedEmployeeName(string firstName)
        {
            string headerLocatorXpath = "//h6[contains(normalize-space(),'@@@@@')]";
            headerLocatorXpath = headerLocatorXpath.Replace("@@@@@", firstName);
            return driver.FindElement(By.XPath(headerLocatorXpath)).Text;
        }

    }
}
