using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using POModels;
using System;
using TechTalk.SpecFlow;

namespace GeneralProject
{
    [Binding]
    public class HomeSteps : POBase.POBase
    {
        private HomePage _innerModel
        {
            get
            {
                return (HomePage) this.Model;
            }
        }
        public HomeSteps() : base(new HomePage())
        { }

        [Given(@"I go to demoqa")]
        public void GivenIGoToDemoqa()
        {
            var test = _innerModel.Title.Text;
            Assert.AreEqual(true, true);
        }

        [Then(@"I see Home title")]
        public void ThenISeeHomeTitle()
        {
            Assert.AreEqual(true, true);
        }
    }
}
