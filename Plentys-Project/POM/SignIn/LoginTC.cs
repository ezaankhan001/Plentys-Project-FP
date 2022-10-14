using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.SignIn
{
    [TestClass]
    public class LoginTC: BaseClass
    {
        [TestMethod]
        public void UserLogin()
        {
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            Login user = new Login();
            user.LoginUser("ezaan.24khan@gmail.com", "Gamer@3123");

        }
        

    }
}
