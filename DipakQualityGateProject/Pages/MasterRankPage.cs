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
    class MasterRankPage
    {
        private IWebDriver driver;

        public MasterRankPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/div/table[1]")]
        private IWebElement eventQuestTable;

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/div/table[1]/tbody/tr[1]")]
        private IWebElement tableRow;

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/div/table[1]/tbody/tr[1]/td[1]")]
        private IWebElement tableRowImage;

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/div/table[1]/tbody/tr[1]/td[2]/span")]
        private IWebElement tableRowLevelText;

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/div/table[1]/tbody/tr[1]/td[3]/ul/li")]
        private IWebElement overviewButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/div/table[1]/tbody/tr[1]/td[3]/div[2]/ul")]
        private IWebElement questDetailsInformation;

        [FindsBy(How = How.XPath, Using = "//*[@id='schedule']/div/div/table[1]/tbody/tr[1]/td[3]/div[2]/p")]
        private IWebElement overviewButtonClose;

        public bool EventQuestTable()
        {
            return eventQuestTable.Displayed;
        }

        public bool EventQuestTableRow()
        {
            return tableRow.Displayed;
        }

        public bool EventQuestTableRowImage()
        {
            return tableRowImage.Displayed;
        }

        public string EventQuestTableRowLevelText()
        {
            return tableRowLevelText.Text;
        }

        public void OverviewQuestDetails()
        {
            overviewButton.Click();
        }

        public bool OverviewQuestDetailsInformation()
        {
            return questDetailsInformation.Displayed;
        }

        public void OverviewQuestDetailsClose()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='schedule']/div/div/table[1]/tbody/tr[1]/td[3]/div[2]/p")));
            overviewButtonClose.Click();
        }
    }
}
