using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    class AccountPageObject
    {
        public AccountPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "sf-with-ul")]
        public IWebElement btnWomenMenu { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[1]/ul/li[1]/ul/li[2]/a")]
        public IWebElement urlBlouses { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#block_top_menu > ul > li > a[Title = \"Women\"]")]
        public IWebElement womanButton { get; set; }

        public ProductListPageObject ClickBlouses()
        {
            Actions actions = new Actions(PropertiesCollection.driver);
            actions.MoveToElement(btnWomenMenu).Build().Perform();
            Thread.Sleep(200);
            if (urlBlouses.Enabled && urlBlouses.Displayed)
            {
                urlBlouses.Click();
            }

            return new ProductListPageObject();
        }

        public ProductListPageObject ClickWomen()
        {
            womanButton.Click();

            return new ProductListPageObject();
        }
    }
}
