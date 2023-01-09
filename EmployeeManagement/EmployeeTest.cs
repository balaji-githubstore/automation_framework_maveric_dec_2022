using EmployeeManagement.Base;
using EmployeeManagement.Pages;
using EmployeeManagement.Utilities;
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
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.AddValidEmployeeData2))]
        public void AddValidEmployeeTest(string username, string password, string firstName, string middleName, string lastName, string expectedEmpName)
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            //MainPage
            MainPage mainPage = new MainPage(driver);
            mainPage.ClickOnPIMMenu();

            //PIMPage
            PIMPage pIMPage = new PIMPage(driver);
            pIMPage.ClickOnAddEmployee();

            //AddEmployeePage
            AddEmployeePage addEmployeePage = new AddEmployeePage(driver);
            addEmployeePage.EnterFirstName(firstName);
            addEmployeePage.EnterMiddleName(middleName);
            addEmployeePage.EnterLastName(lastName);
            addEmployeePage.ClickOnSave();

            //PersonalDetailsPage
            PersonalDetailsPage personalDetailsPage = new PersonalDetailsPage(driver);

            string actualEmpRecord = personalDetailsPage.GetAddedEmployeeName(firstName);
            Assert.That(actualEmpRecord, Is.EqualTo(expectedEmpName));

        }

        //run above test with two test case 
        //        admin, admin123, John, W, Wick, John Wick
        //admin,admin123,Saul, g, goodman, Saul Goodman

    }
}
