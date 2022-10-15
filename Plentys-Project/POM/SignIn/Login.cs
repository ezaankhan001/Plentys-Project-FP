using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plentys_Project.POM.SignIn
{
    public class Login : BaseClass
    {
        
        By LoginButton = By.XPath("//span[contains(text(), 'Login / Register')]");
        By email = By.Id("loginEmail");
        By password = By.XPath("//input[@id='loginPassword']");
        By submit = By.XPath("//button[@name='Login']");

        public void LoginUser(string Email, string Password)
        {
            Click(LoginButton);
            PlayBackWait(2000);
            Write(email, Email);
            Write(password, Password);
            Click(submit);
            //The system send an OTP on email provided which needs to be entered manually
            //The OTP is needed once just for the verification of email
            //ImplicitWait(30);
            
        }


    }
}
