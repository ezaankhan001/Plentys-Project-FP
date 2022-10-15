using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.NewsLetter
{
    [TestClass]
    public class SubscribeNewsLetterTC : BaseClass
    {
        [TestMethod]
        public void Newsletter()
        {
            Browsers("edge");
            OpenURL("https://plentys.pk/");
            SubscribeNewsLetter subs = new SubscribeNewsLetter();
            subs.NewsletterSubscription("ezaankhan024@gmail.com", "3228494340");
        }
    }
}
