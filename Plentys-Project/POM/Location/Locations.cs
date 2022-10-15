using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.Location
{
    public class LocationsTC : BaseClass
    {
        By location = By.XPath("(//div[@class='_3hr9rij5aFmslaAuXbcyU2'])[6]");
        By city = By.XPath("//a[contains(text(), 'Karachi')]");
        By Agree = By.XPath("//button[contains(text(),'Agree')]");

        public void loc()
        {
            Click(location);
            Click(city);
            Click(Agree);
        }
    }
}
