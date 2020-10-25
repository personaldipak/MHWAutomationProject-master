using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using DipakQualityGateProject.Pages;
using System.Threading;

namespace DipakQualityGateProject.Steps
{
    [Binding]
    public class IceborneSteps
    {
        private IWebDriver driver;
        private Homepage homepage;
        private IceborneEvent iceborneEvents;
        private MasterRankPage masterRank;

        [Scope(Feature = "Iceborne")]
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            iceborneEvents = new IceborneEvent(driver);
            homepage = new Homepage(driver);
            masterRank = new MasterRankPage(driver);
        }

        [Given(@"I am on the Main-page")]
        public void GivenIAmOnTheMain_Page()
        {
            homepage.GoToPage();
            string expectedLink = "https://www.monsterhunterworld.com/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Given(@"I am on the iceborne homepage")]
        public void GivenIAmOnTheHomePage()
        {
            iceborneEvents.IceborneOfficalSite();
            string expectedLink = "https://www.monsterhunter.com/world-iceborne/uk/";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [Given(@"I click on consent messagebox")]
        public void GivenIClickOnConsentMessagebox()
        {
            homepage.MessageBox();
        }

        [Given(@"I am on the EventQuest schedule")]
        public void GivenIAmOnTheEventQuestSchedule()
        {
            iceborneEvents.EventQuest();
            string expectedLink = "http://game.capcom.com/world/uk/rank.html";
            Assert.AreEqual(expectedLink, driver.Url);
        }

        [When(@"I am on the Master Rank")]
        public void WhenIAmOnTheMasterRank()
        {
            iceborneEvents.MasterRank();
            string expectedLink = "http://game.capcom.com/world/uk/schedule-master.html";
            Assert.AreEqual(expectedLink, driver.Url);

        }

        [Then(@"I should be able to see Event Schedule date")]
        public void ThenIShouldBeAbleToSeeEventScheduleDate()
        {
            string result = iceborneEvents.MasterRankDates();
            Assert.AreEqual("10/18～11/08 (UTC+1)", result);
        }

        [Then(@"I should be able to see Event Schedule table")]
        public void ThenIShouldBeAbleToSeeEventSchedule()
        {
            bool TableExist = masterRank.EventQuestTable();
            Assert.IsTrue(TableExist);
        }

        [Then(@"I should be able to see Event Schedule table row")]
        public void ThenIShouldBeAbleToSeeEventScheduleTableRow()
        {
            bool tableRowExist = masterRank.EventQuestTableRow();
            Assert.IsTrue(tableRowExist);
        }

        [Then(@"I should be able to see the image on table row")]
        public void ThenIShouldBeAbleToSeeTheImageOnTableRow()
        {
            bool tableRowImageExist = masterRank.EventQuestTableRowImage();
            Assert.IsTrue(tableRowImageExist);
        }

        [Then(@"I should be able to see the level text on table row")]
        public void ThenIShouldBeAbleToSeeTheLevelTextOnTableRow()
        {
            string leveltext = masterRank.EventQuestTableRowLevelText();
            Assert.AreEqual("MR 1★", leveltext);
        }

        [Then(@"I should be able to click on quest details link on table row")]
        public void ThenIShouldBeAbleToClickOnQuestDetailsLinkOnTableRow()
        {
            masterRank.OverviewQuestDetails();
        }

        [Then(@"I should be able to see quest details information")]
        public void ThenIShouldBeAbleToSeeQuestDetailsInformation()
        {
            bool questDetailsInformation = masterRank.OverviewQuestDetailsInformation();
            Assert.IsTrue(questDetailsInformation);
        }

        [Then(@"I should be able to close the pop-up window")]
        public void ThenIShouldBeAbleToCloseThePop_UpWindow()
        {
            masterRank.OverviewQuestDetailsClose(); 
        }

        [Scope(Feature = "Iceborne")]
        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }

    }
}
