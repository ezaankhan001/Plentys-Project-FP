using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Plentys_Project.POM.AddToCart
{
    [TestClass]
    public class AddToCartTC: BaseClass
    {
        [TestMethod]
        public void AddProductToCart()
        {
            Browsers("chrome");
            OpenURL("https://www.plentys.pk/");
            AddToCart prdt = new AddToCart();
            prdt.Cart();
        }
    }
}
