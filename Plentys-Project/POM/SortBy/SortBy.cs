using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Plentys_Project.POM.SortBy
{
    public class SortBy:BaseClass
    {
        By hamBurger = By.XPath("//*[@id='root']/header/div[2]/div[1]/button");
        By mobile = By.XPath("//li[@id='2']");
        By sort = By.XPath("//select[@class='custom-select custom-select-sm']");


        public void Sort()
        {
            Hover(hamBurger);
            HoverNClick(mobile);
            PlayBackWait(5000);
            DropDown(sort, "Discount Products");
        }
    }
}
