using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POBase
{
    public class POBase
    {
        private IWebDriver _driver { get { return Driver.WebDriver; } }
        public object Model { get; set; }

        public POBase(object model)
        {
            Model = model; 
            PageFactory.InitElements(_driver, Model); 
        } 
    }
}
