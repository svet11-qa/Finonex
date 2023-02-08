using NUnit.Framework;
using Finonex.Browser;
using OpenQA.Selenium;
using Finonex.Pages;

namespace Finonex.Tests
{
    internal class SomeTests
    {
        public static WebDriver Driver;

        BasePage basePage = new();

        [SetUp]

        public void SomeStuff()
        {
            Driver ??= DriverSettings.SetupBrowser("Chrome");
            Driver.Navigate().GoToUrl("https://www.fortrade.com/create-user/?tg=skip&tag1=break&G_GEO=9075129");
        }

        [TestCase]
        public void SomeTestCase()
        {
            basePage.AddUser();
        }
        [TearDown]
        public void SomeTearDown()
        {
            Driver.Quit();
        }
    }
}
