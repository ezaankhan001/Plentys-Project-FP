using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Plentys_Project
{
    public class AddToCart : BaseClass
    {
        By product = By.XPath("(//a[@title='Comelle Regular Tin Sweetened Condensed Milk 397gm'])[1]");
        By element1 = By.XPath("//b[text()='Flash Deal']");
        By cartButton =By.XPath("//button[text() = 'Add to Cart']");

        public void Cart()
        {
            ScrollToElement(element1);
            ImplicitWait(3);
            Click(product);
            Click(cartButton);
        }
    }
}
