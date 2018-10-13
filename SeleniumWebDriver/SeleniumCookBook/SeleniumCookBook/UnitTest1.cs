using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCookBook
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string url = "http://www.google.com";
            string name = "q";
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            
            IWebElement element = driver.FindElement(By.Name(name));
            string message = null;
            element.SendKeys(message);

            element.Submit();
        }
    }
}
