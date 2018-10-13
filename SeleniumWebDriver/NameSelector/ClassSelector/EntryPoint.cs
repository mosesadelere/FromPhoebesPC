using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

    class EntryPoint
{
    static void Main()
    {
        string className = "testClass";
        string gotoUrl = "http://testing.todorvachev.com/selectors/class-name/";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(gotoUrl);


        IWebElement element = driver.FindElement(By.ClassName(className));

        if (element.Displayed)
        {
            Console.WriteLine(element.Text);
        }
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
