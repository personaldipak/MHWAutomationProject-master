using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipakQualityGateProject.Pages
{
    class IceborneEvent
    {
        private IWebDriver driver;

        public IceborneEvent(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='eq_dlc']/li[1]/a")]
        private IWebElement eventQuest;

        [FindsBy(How = How.XPath, Using = "//*[@id='wrap']/section/div/ul/li[1]/a")]
        private IWebElement masterRank;

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/p")]
        private IWebElement rankDate;

        public void IceborneOfficalSite()
        {
            driver.Navigate().GoToUrl("https://www.monsterhunter.com/world-iceborne/uk/");
        }

        public void EventQuest()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='eq_dlc']/li[1]/a")));
            eventQuest.Click();
        }

        public void MasterRank()
        {
            masterRank.Click();
        }

        public string MasterRankDates()
        {
            return rankDate.Text;
        }
    }
}
