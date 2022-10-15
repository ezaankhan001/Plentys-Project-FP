using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.Location
{
 
    [TestClass]
    public class Locations : BaseClass
    {
        [TestMethod]
        public void Location()
        {
            Browsers("chrome");
            OpenURL("https://plentys.pk/");
            LocationsTC location = new LocationsTC();
            location.loc();
        }
    }
}
