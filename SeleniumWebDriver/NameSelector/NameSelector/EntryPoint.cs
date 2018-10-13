
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {

        string name = "userName";
        string password = "password";
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://www.google.com");

        IWebElement element = driver.FindElement(By.Name(name)).FindElement(By.Id(password));

        element.SendKeys("Hello Selenium Driver!!!");
        element.Submit();


        if (element.Displayed)
        {
            GreenMessage("Yes! I can see the element, it's right there!!!");
        }
        else
        {
            RedMessage("Well, something went wrong, I couldn't see the element!");
        }


        // Thread.Sleep(3300);

        driver.Quit();

        Console.ReadKey();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

