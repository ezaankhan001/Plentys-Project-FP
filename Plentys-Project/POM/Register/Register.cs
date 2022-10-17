
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;

namespace Plentys_Project
{
    public class Register : BaseClass
    {
        By LoginButton = By.XPath("//span[contains(text(), 'Login / Register')]");
        By register = By.XPath("//button[@name='Register']");
        By fname = By.XPath("//input[@name='fullName']");
        By email = By.XPath("//input[@name='email']");
        By telephone = By.XPath("//input[@type='tel']");
        By password = By.XPath("//input[@name='password']");
        By confirmPassword = By.XPath("//input[@name='confirmPassword']");
        By referCode = By.XPath("//input[@name='userReferralCode']");
        By robo = By.XPath("//*[@id='recaptcha-anchor']/div[1]");
        By submit = By.XPath("(//button[@type='submit'])[1]");
        By ifrm = By.XPath("//*[@id=\"main-content\"]/div[1]/div/div/div[2]/div/div/form/div[7]/div/div/div/div/iframe");
     
        
        public void registration(string Fname, string Email, string Telephone, string Password, string ConfirmPassword, string Code)
        {
            Click(LoginButton);
            ImplicitWait(2);
            Click(register);
            Write(fname, Fname);
            Write(email, Email);
            Write(telephone, Telephone);
            Write(password, Password);
            Write(confirmPassword, ConfirmPassword);
            Write(referCode, Code);
            SwitchFrame(ifrm);
            HoverNClick(robo);
            SwitchDefault();
            Click(submit);
        }
    }
}
