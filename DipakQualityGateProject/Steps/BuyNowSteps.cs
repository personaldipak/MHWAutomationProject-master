using DipakQualityGateProject.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace DipakQualityGateProject.Steps
{
    [Binding]
    public class BuyNowSteps
    {
        private IWebDriver driver;
        private Homepage homepage;
        private IceborneEvent iceborne;
        private BuyNowPage buyNow;

        [Scope(Feature = "BuyNow")]
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            homepage = new Homepage(driver);
            iceborne = new IceborneEvent(driver);
            buyNow = new BuyNowPage(driver);
        }

        [Given(@"I am on the HomePage")]
        public void GivenIAmOnTheHomePage()
        {
            homepage.GoToPage();
            string expectedLink = "https://www.monsterhunterworld.com/";
            Assert.AreEqual(expectedLink, driver.Url);
        }
        
        [Given(@"I am on Iceborne uk homepage")]
        public void GivenIAmOnIceborneUkHomepage()
        {
            iceborne.IceborneOfficalSite();
            string expectedLink = "https://www.monsterhunter.com/world-iceborne/uk/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Given(@"I click on ok messagebox")]
        public void GivenIClickOnOkMessagebox()
        {
            homepage.MessageBox();
        }

        [Given(@"I click on Buy now button")]
        public void GivenIClickOnBuyNowButton()
        {
            buyNow.BuyNow();
        }
        
        [When(@"I choose prefernce (.*)")]
        public void WhenIChoosePrefernce(int p0)
        {
            buyNow.ExistingOption();
        }
        
        [Then(@"I click on buy now button")]
        public void ThenIClickOnBuyNowButton()
        {
            buyNow.BuyNowButton();
            string expectedLink = "https://store.playstation.com/en-gb/product/EP0102-CUSA07708_00-ICEBORNEXPANSION";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Then(@"I choose steam option")]
        public void ThenIChooseSteamOption()
        {
            buyNow.SteamOption();
        }

        [Then(@"I should be able to see a message")]
        public void ThenIShouldBeAbleToSeeAMessage()
        {
            string expectText = buyNow.SteamMessage();
            Assert.AreEqual("Steam version coming January 2020.\r\nStay tuned for more detailed information.", expectText);
        }

        [Scope(Feature = "BuyNow")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}
