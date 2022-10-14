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
        [TestMethod]
        public void RegisterUser()
        {
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            Register reg = new Register();
            reg.registration("Ezaan Khan", "ezaan.24khan@gmail.com", "3228494340", "Gamer@3123", "Gamer@3123", "23432");

        }
    }
}
