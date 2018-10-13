using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WebTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            IAlert alert;
            IWebElement image;

            string url = "http://testing.todorvachev.com/special-element/alert-box/";
            driver.Navigate().GoToUrl(url);

            alert = driver.SwitchTo().Alert();

            Console.WriteLine(alert.Text);

            alert.Accept();

            image = driver.FindElement(By.CssSelector("#post-119 > div > figure > > img"));

            try
            {
                if (image.Displayed)
                {
                    Console.WriteLine("The alert was successfully accepted and I can see the image!");
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong!!");
            }

            Thread.Sleep(3000);
            driver.Dispose();

        }
    }
}
