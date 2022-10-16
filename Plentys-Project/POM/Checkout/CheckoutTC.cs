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
using Plentys_Project.POM.SignIn;


namespace Plentys_Project.POM.Checkout
{
    [TestClass]
    public class CheckoutTC: BaseClass
    {
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
