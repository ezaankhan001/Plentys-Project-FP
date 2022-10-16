using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plentys_Project.POM.SignIn;


namespace Plentys_Project.POM.Logout
{
    [TestClass]
    public class LogoutTC: BaseClass
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }

        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {

            ExtentReport.LogReport("Sorting Functionality Report");
        }
        [ClassCleanup]
        [TestMethod]
    public void logoutUser()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Sorting Functionality Test");
            Browsers("edge");
            OpenURL("https://plentys.pk/");
            Login user = new Login();
            user.LoginUser("ezaan.24khan@gmail.com", "Gamer@3123");
            Logout LOut = new Logout();
            LOut.logout();
        }
    }
}
