using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POBase
{
    public static class Driver
    {
        public static IWebDriver WebDriver { get; set; } 

        static Driver()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Navigate().GoToUrl("http://demoqa.com/");
        }
    }
}
