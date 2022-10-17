using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;


namespace Plentys_Project
{

    [TestClass]
    public class CheckoutTC: BaseClass
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
        public void CheckoutAsUser()
        {
            Browsers("chrome");
            OpenURL("https://plentys.pk/");
            Checkout asUser = new Checkout();
            asUser.ProceedAsGuest();
            Login login = new Login();
            login.LoginUser("ezaan.24khan@gmail.com", "Gamer@3123");
        }
    }
}
