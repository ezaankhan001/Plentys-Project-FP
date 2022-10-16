using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Plentys_Project.POM.Filters
{
    [TestClass]
    public class FiltersTC : BaseClass
    {
        [TestMethod]
        public void filters()
        {
            Browsers("chrome");
            OpenURL("https://plentys.pk/");
            Filters fltr = new Filters();
            fltr.PageFilters("10", "2000");
        }
    }
}
