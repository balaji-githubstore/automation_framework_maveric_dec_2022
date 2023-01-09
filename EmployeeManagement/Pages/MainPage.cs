using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    //handle all menu
    public class MainPage
    {
        private By _pimMenuLocator = By.XPath("//span[text()='PIM']");

        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetMainpageUrl()
        {
            return driver.Url;
        }

        public void ClickOnPIMMenu()
        {
            driver.FindElement(_pimMenuLocator).Click();
        }
    }
}
