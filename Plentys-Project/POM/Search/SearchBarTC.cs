using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.Search
{
    [TestClass]
    public class SearchBarTC : BaseClass
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
        public void SearchWithValidData()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Sorting Functionality Test");
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            SearchBar text = new SearchBar();
            text.Search("Fair & Lovely");
            ImplicitWait(3);
            string actual = findElement(By.XPath("(//p[text()='Fair & Lovely'])[1]")).Text;
            Assert.AreEqual("Fair & Lovely", actual);
        }


        [TestMethod]
        public void SearchWithInValidData()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Sorting Functionality Test");
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            SearchBar text = new SearchBar();
            text.Search("Cars");
            ImplicitWait(3);
            
        }

        [TestMethod]
        public void SearchWithEmpty()
        {
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Sorting Functionality Test");
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            SearchBar text = new SearchBar();
            text.Search("");
            ImplicitWait(3);
           
        }

    }
}
