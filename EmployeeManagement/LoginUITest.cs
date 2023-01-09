using EmployeeManagement.Base;
using EmployeeManagement.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest : AutomationWrapper
    {
        [Test]
        public void ValidateTitleTest()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));
        }

        [Test]
        public void ValidatePlaceholderTest()
        {
            LoginPage loginPage = new LoginPage(driver);

            string actualUsernamePlaceholder = loginPage.GetUserNamePlaceholder();
            //string actualPasswordPlaceholder = loginPage.GetPasswordPlaceholder();

            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            Assert.That(loginPage.GetPasswordPlaceholder(), Is.EqualTo("Password"));
        }

    }
}