using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.NewsLetter
{
    public class SubscribeNewsLetter : BaseClass
    {
        By newsletter = By.XPath("//h5[text()='Newsletter Subscription']");
        By EmailAddress = By.XPath("//input[@id='userEmail']");
        By Phone = By.XPath("//input[@id='phoneNo']");
        By submit = By.XPath("(//button[@type='submit'])[2]");


        public void NewsletterSubscription(string email, string phone)
        {
            Write(EmailAddress, email);
            Write(Phone, phone);
            Click(submit);

        }
    }
}
