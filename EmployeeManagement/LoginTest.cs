using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Base;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {

        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            //enter password as admin123
            //click on login 

            //Assert the url 
        }


    }
}
