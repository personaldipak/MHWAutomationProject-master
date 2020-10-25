using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using DipakQualityGateProject.Pages;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace DipakQualityGateProject.Steps
{
    [Binding]
    public class MhwMainPageSteps
    {
        //defines the interface through which the user controls the browsers
        private IWebDriver driver;
        private Homepage homepage;

        [Scope(Feature = "MhwMainPage")]
        [BeforeScenario]
        public void BeforeScenario()
        {
            //start the browsers
            driver = new ChromeDriver();
            //maximuize the window screen size
            driver.Manage().Window.Maximize();
            homepage = new Homepage(driver);
        }

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            homepage.GoToPage();
            string expectedLink = "https://www.monsterhunterworld.com/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Given(@"I click on messagebox")]
        public void GivenIClickOnMessagebox()
        {
            homepage.MessageBox();
        }

        [When(@"I have select the UK language")]
        public void WhenIHaveSelectTheLanguage()
        {
            homepage.SelectLanguage();
            string expectedText = "English(UK)";
            Assert.AreEqual(expectedText, driver.FindElement(By.XPath("//*[@id='language']/select/option[3]")).Text);
        }
        
        [Then(@"Click on console offical site button")]
        public void ThenIHavenChosenConsoleOfficalSite()
        {
            homepage.OfficalSite();
            string expectedLink = "http://www.monsterhunterworld.com/uk/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Then(@"Click on steam offical site button")]
        public void ThenIHavenChosenSteamOfficalSite()
        {
            homepage.SteamSite();
            string expectedLink = "http://www.monsterhunterworld.com/pc/uk/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Scope(Feature = "MhwMainPage")]
        [AfterScenario]
        public void AfterScenario()
        {
            //end the browsers
            driver.Close();
        }
    }
}
