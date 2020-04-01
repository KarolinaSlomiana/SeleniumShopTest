using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    public static class SeleniumSetMethods
    {
        public static void EnterText(string element, string value, PropertyType propertyType)
        {
            if (propertyType == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (propertyType == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public static void SelectDropDown(string element, string value, PropertyType propertyType)
        {
            if (propertyType == PropertyType.Id)
            new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
        }

        internal static void Click(this IWebElement element)
        {
            element.Click();
        }
    }
}
