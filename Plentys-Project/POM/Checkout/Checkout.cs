using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Plentys_Project
{
    public class Checkout : BaseClass
    {
        By Product = By.XPath("//a[@title='MATTE and PORELESS Liquid Foundation']");
        By Color = By.XPath("(//div[@class='jWIpwjbR6N0XhA0tkJydS'])[1]");
        By BuyNow = By.XPath("//button[@class=_1B4mvg2oIt5HB7r70a8zWa btn btn-primary btn-block]");
        By LoginAsUser = By.XPath("//button[@class='_2eUzV9mH_kb0yqlBJPoEum btn btn-primary btn-block' and text()='Login as User']");
        By LoginAsGuest = By.XPath("//button[@class='undefined btn-secondary rounded-0 btn btn-primary btn-block' and text()='Login as Guest']");
        By FullName = By.XPath("//input[@name='guestFullName']");
        By Email = By.XPath("//input[@name='guestEmal']");
        By Continue = By.XPath("//button[@type='submit' and text()='Continue']");
        By RegisterButton = By.XPath("//button[text()='Register']");

        public void ProceedAsGuest()
        {
            Click(Product);
            Click(Color);
            Click(BuyNow);
            Click(LoginAsUser);
        }

        public void ProceedAsUser(string name, string email)
        {
            Click(Product);
            Click(Color);
            Click(BuyNow);
            Write(FullName,name);
            Write(Email, email);
        }


    }

}