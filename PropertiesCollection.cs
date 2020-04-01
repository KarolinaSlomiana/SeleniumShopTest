using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    public class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }

        public static Random random = new Random();
    }

     public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        XPath,
        CssName,
        ClassName
    }
}
