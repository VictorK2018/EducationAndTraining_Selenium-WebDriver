using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)

        {
            FirefoxDriver driver = new FirefoxDriver();

            driver.Url = "http://localhost/litecart/admin/";
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            
            driver.FindElement(By.Name("login")).Click();
            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //driver.FindElement(By.ClassName("fa fa-sign-out fa-lg")).Click();
            //driver.FindElement(By.LinkText("http://localhost/litecart/admin/logout.php"));
            //driver.FindElement(By.Name("title=\"Logout")).Click();
            //driver.FindElement(By.LinkText("Logout")).Click();

            driver.FindElement(By.CssSelector("[title *=Logout]")).Click();
            
            driver.Quit();

        }
    }
}
