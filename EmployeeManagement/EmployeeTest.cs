using EmployeeManagement.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeTest : AutomationWrapper
    {
        [Test]
        public void AddValidEmployeeTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();

            //click on PIM Menu
            //Click on add employee
            //Enter firstname, lastname, middle name
            //click on save
            //validate the added name John wick

        }

        //run above test with two test case 
//        admin, admin123, John, W, Wick, John Wick
//admin,admin123,Saul, g, goodman, Saul Goodman

    }
}
