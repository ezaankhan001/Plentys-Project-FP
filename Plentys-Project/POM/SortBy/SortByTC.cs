using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.SortBy
{
    [TestClass]
    public class SortByTC: BaseClass
    {
        [TestMethod]
        public void SortBy()
        {
            Browsers("chrome");
            OpenURL("https://plentys.pk/");
            SortBy sorting = new SortBy();
            sorting.Sort();
        }
    }
}
