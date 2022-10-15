using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Plentys_Project.POM.Logout
{
    public class Logout: BaseClass
    {
        By accountIcon = By.XPath("//*[@id='root']/header/div[1]/div[5]/div/h5/a");
        By logoutButton = By.XPath("//a[contains(text(),'Logout')]");


        public void logout()
        {
            PlayBackWait(1000);
            Click(accountIcon);
            Click(logoutButton);
        }
    }
}
