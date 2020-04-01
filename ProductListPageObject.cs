using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    class ProductListPageObject
    {
        public ProductListPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".product-container .product-name")]
        public IList<IWebElement> nameProduct { get; set; }

        public ProductPageObject ChooseProduct()
        {
            int randomProduct = PropertiesCollection.random.Next(nameProduct.Count);
            nameProduct[randomProduct].Click();

            return new ProductPageObject();
        }
    }
}
