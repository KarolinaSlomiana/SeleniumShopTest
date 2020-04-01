using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement txtEmailAdress { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement btnLogin { get; set; }

        public AccountPageObject Login(string userName, string password)
        {
            Thread.Sleep(2000);
            txtEmailAdress.SendKeys(userName);
            txtPassword.EnterText(password);
            btnLogin.Click();

            return new AccountPageObject();
        }
    }
}
