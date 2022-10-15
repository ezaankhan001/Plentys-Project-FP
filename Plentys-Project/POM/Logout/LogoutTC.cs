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
    [TestMethod]
    public void logoutUser()
        {
            Browsers("edge");
            OpenURL("https://plentys.pk/");
            Login user = new Login();
            user.LoginUser("ezaan.24khan@gmail.com", "Gamer@3123");
            Logout LOut = new Logout();
            LOut.logout();
        }
    }
}
