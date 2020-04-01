using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    class HomePageObject
    {
        public HomePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using="login")]
        public IWebElement btnSignIn { get; set; }

        public LoginPageObject SignIn()
        {
            btnSignIn.Click();

            return new LoginPageObject();
        }

    }
}
