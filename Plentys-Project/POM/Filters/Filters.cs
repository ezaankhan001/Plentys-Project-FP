using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plentys_Project
{
    public class Filters: BaseClass
    {

        By HamBurger = By.XPath("//*[@id='root']/header/div[2]/div[1]/button");
        By HomeLifestyle = By.XPath("//li[@id='4']");
        By Brand = By.XPath("(//div[@class='form-check']//input[@id='SAC-1'])[2]");
        //By brand1 = By.Id("SAC-1");
        By PriceMin = By.XPath("(//input[@step='1'])[3]");
        By PriceMax = By.XPath("(//input[@step='1'])[4]");
        By ApplyPriceFilter = By.XPath("(//button[contains(text(),'GO')])[2]");
        By Discount = By.XPath("(//div[@class='form-check']//input[@id='10% and above-0'])[2]");
        By Promotion = By.XPath("(//div[@class='form-check']//input[@id='Discount-0'])[2]");
        By Rating = By.XPath("(//div[@class='form-check']//input[@id='4 stars and above-0'])[2]");
        //By ColorSearch = By.XPath("((//*[@id='formBasicCheckbox'])[3]");
        By Color = By.XPath("(//div[@class='form-check']//input[@id='Black-0'])[2]");
        //By Material = By.XPath("(//div[@class='form-check']//input[@id='Plastic-1'])[2]");
        By Type = By.XPath("(//*[@id='Fragrance-2''])[1]");

        

        
        public void PageFilters(string min, string max)
        {
            Hover(HamBurger);
            Click(HomeLifestyle);
            ImplicitWait(10);
            Click(Brand);
            //Click(brand1);
            ImplicitWait(3);
            Write(PriceMin, min);
            Write(PriceMax, max);
            ImplicitWait(3);
            Click(ApplyPriceFilter);
            ImplicitWait(3);
            Click(Discount);
            ImplicitWait(3);
            Click(Promotion);
            ImplicitWait(3);
            Click(Rating);
            ImplicitWait(3);
            Click(Color);
            //Click(Material);
            Click(Type);


        }
    }
}
