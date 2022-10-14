using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.Search
{
    [TestClass]
    public class SearchBarTC : BaseClass
    {
        [TestMethod]
        public void searchbar()
        {
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");

            SearchBar text = new SearchBar();
            text.Search("Fair & Lovely");
            ImplicitWait(3);
            string actual = findElement(By.XPath("(//p[text()='Fair & Lovely'])[1]")).Text;
            Assert.AreEqual("Fair & Lovely", actual);
        }
    }
}
