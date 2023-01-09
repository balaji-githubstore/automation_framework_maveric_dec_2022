using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Base;
using EmployeeManagement.Utilities;
using EmployeeManagement.Pages;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
        [Test,Retry(2)]
        public void ValidLoginTest()
        {
            LoginPage loginPage= new LoginPage(driver);

            loginPage.EnterUsername("Admin");
            loginPage.EnterPassword("admin123");
            loginPage.ClickOnLogin();

            MainPage mainPage=new MainPage(driver);

            string actualUrl = mainPage.GetMainpageUrl();
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }

        [Test,TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData2))]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            string actualError = loginPage.GetInvalidErrorMessage();
 
            //Assert the error message Invalid credentials
            Assert.That(actualError.Contains(expectedError), "Assertion on error message");
        }
    }
}
