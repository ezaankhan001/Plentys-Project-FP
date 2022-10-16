using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project.POM.Filters
{
    public class Filters: BaseClass
    {

        By HamBurger = By.XPath("//*[@id='root']/header/div[2]/div[1]/button");
        By HomeLifestyle = By.XPath("//li[@id='4']");
        By Brand = By.XPath("((//*[@id=\"SAC-2\"])[2]");
        By PriceMin = By.XPath("(//input[@step='1'])[3]");
        By PriceMax = By.XPath("(//input[@step='1'])[4]");
        By ApplyPriceFilter = By.XPath("(//button[contains(text(),'GO')])[2]");
        By Discount = By.XPath("//input[@name='discount'])[5]");
        By Promotion = By.XPath("(//*[@id='Buy & Get Free-1'])[1]");
        By Rating = By.XPath("(//*[@id='4 stars and above-0'])[1]]");
        //By ColorSearch = By.XPath("((//*[@id='formBasicCheckbox'])[3]");
        By Color = By.XPath("(//*[@id='Black-0'])[1]");
        By Material = By.XPath("(//*[@id='Plastic-1'])[1]");
        By Type = By.XPath("(//*[@id='Fragrance-2''])[1]");   



        public void PageFilters(string min, string max)
        {
            Hover(HamBurger);
            Click(HomeLifestyle);
            Click(Brand);
            Write(PriceMin, min);
            Write(PriceMax, max);
            Click(ApplyPriceFilter);
            Click(Discount);
            Click(Promotion);
            Click(Rating);
            Click(Color);
            Click(Material);
            Click(Type);


        }
    }
}
