using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;

namespace Plentys_Project.POM.Register
{
    [TestClass]
    public class RegisterTC: BaseClass
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
        public void RegisterUserWithValidData()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Sorting Functionality Test");
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            Register reg = new Register();
            reg.registration("Ezaan Khan", "ezaan.24khan@gmail.com", "3228494340", "Gamer@3123", "Gamer@3123", "23432");
        }

        [TestMethod]
        public void RegisterUserWithInValidData()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Sorting Functionality Test");
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            Register reg = new Register();
            reg.registration("Ezaan Khan", "ezaan@godaddyg.com", "3228494340", "Gamer@3123", "Gamer@3123", "23432");
        }
    }
}
