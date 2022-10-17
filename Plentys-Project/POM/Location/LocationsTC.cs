using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project
{
 
    [TestClass]
    public class Locations : BaseClass
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
        public static void ClassCleanUp()
        {
            ExtentReport.extentReports.Flush();
        }

        [TestMethod]
        public void Location()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Sorting Functionality Test");
            Browsers("chrome");
            OpenURL("https://plentys.pk/");
            LocationsTC location = new LocationsTC();
            location.loc();
        }

    }
}
