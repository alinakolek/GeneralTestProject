using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POModels
{
    public class HomePage
    { 
        [FindsBy(How = How.CssSelector, Using = "h1[class=\"entry-title\"]")]
        public IWebElement Title { get; set; }  
    }
}
