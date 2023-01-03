using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest
    {
        [Test]
        public void ValidateTitleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://opensource-demo.orangehrmlive.com/";

            string actualTitle = driver.Title;
            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));
        }

        [Test]
        public void ValidatePlaceholderTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://opensource-demo.orangehrmlive.com/";

            string actualUsernamePlaceholder=driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");

            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));
        }

    }
}