using EmployeeManagement.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest : AutomationWrapper
    {
        [Test,Repeat(3),Retry(2)]
        public void ValidateTitleTest()
        {
            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));
        }

        [Test]
        public void ValidatePlaceholderTest()
        {
            string actualUsernamePlaceholder = driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");

            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));
        }

    }
}