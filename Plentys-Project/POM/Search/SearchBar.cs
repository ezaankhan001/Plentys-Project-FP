using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project
{
    public class SearchBar: BaseClass
    {
        By mobileAndTablet = By.XPath("//select[@id='resizing_select']/option[1]");
        By searchBar = By.XPath("//input[@placeholder='Search Your Product Here']");
        By searchButton = By.XPath("(//button[@type='submit'])[1]");

        public void Search(string searchText)
        {
            Click(mobileAndTablet);
            Write(searchBar, searchText);
            Click(searchButton);
        }


    }
}
