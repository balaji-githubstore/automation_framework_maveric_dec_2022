using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class LoginPage
    {
        private By _usernameLocator = By.Name("username");
        private By _passwordLocator= By.Name("password");
        private By _loginLocator = By.XPath("//button[normalize-space()='Login']");
        private By _forgotPasswordLocator = By.XPath("//p[contains(normalize-space(),'Forgot')]");
        private By _errorLocator = By.XPath("//p[contains(normalize-space(),'cred')]");

        private IWebDriver driver;
        private DefaultWait<IWebDriver> _wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;

            _wait = new DefaultWait<IWebDriver>(driver);
            _wait.IgnoreExceptionTypes(typeof(Exception));
            _wait.Timeout=TimeSpan.FromSeconds(30);
        }

        public void EnterUsername(string username)
        {
            //driver.FindElement(_usernameLocator).SendKeys(username);

            _wait.Until(x => x.FindElement(_usernameLocator)).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLocator).SendKeys(password);
        }

        public void ClickOnLogin()
        {
            driver.FindElement(_loginLocator).Click();
        }

        public void ClickOnForgotPassword()
        {
            driver.FindElement(_forgotPasswordLocator).Click();
        }

        public string GetInvalidErrorMessage()
        {
            return driver.FindElement(_errorLocator).Text;
        }

        public string GetUserNamePlaceholder()
        {
            return driver.FindElement(_usernameLocator).GetAttribute("placeholder"); 
        }

        public string GetPasswordPlaceholder()
        {
            return driver.FindElement(_passwordLocator).GetAttribute("placeholder");
        }

    }
}
