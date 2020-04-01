using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    class ProductPageObject
    {
        public ProductPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How=How.Id, Using ="quantity_wanted")]
        public IWebElement txtQuantityWanted { get; set; }
        [FindsBy(How=How.Id, Using="group_1")]
        public IWebElement drpSize { get; set; }
        [FindsBy(How=How.ClassName, Using="color_pick")]
        public IList<IWebElement> btnColor { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#add_to_cart > button")]
        public IWebElement btnAddToCart { get; set; }

        public void ParametersSelector(string quantity, string size)
        {
            txtQuantityWanted.Clear();
            txtQuantityWanted.SendKeys(quantity);
            new SelectElement(drpSize).SelectByText(size);
            int randomColor = PropertiesCollection.random.Next(btnColor.Count);
            btnColor[randomColor].Click();
        }

        public void AddToCart()
        {
            btnAddToCart.Click();
        }
    }
}
