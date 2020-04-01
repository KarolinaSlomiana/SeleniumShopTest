using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumShopTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {

            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }

        [Test]
        public void AddRandomProductToCart()
        {
            HomePageObject homePage = new HomePageObject();
            LoginPageObject loginPage = homePage.SignIn();
            AccountPageObject accountPage = loginPage.Login("siiwyoitytrgbejcdo@awdrt.net", "12345");
            ProductListPageObject productListPage = accountPage.ClickWomen();
            ProductPageObject productPageObject = productListPage.ChooseProduct();
            productPageObject.ParametersSelector("3", "M");
            productPageObject.AddToCart();


        }

        [TearDown]
        public void CleanUp()
        {
            //PropertiesCollection.driver.Close();
        }
    }
}
