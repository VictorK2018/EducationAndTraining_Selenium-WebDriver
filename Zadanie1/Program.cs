using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.google.ca/";

            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.Quit();
        }
    }
}
