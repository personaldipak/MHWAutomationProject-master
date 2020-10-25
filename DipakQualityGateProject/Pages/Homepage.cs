using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace DipakQualityGateProject.Pages
{
    class Homepage
    {
        //The driver that will be used to look up the elements
        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            //this initElements method will create all the webelements
            PageFactory.InitElements(driver, this);
        }

        // Find the element that's Xpath attribute is 'select language'
        [FindsBy(How = How.XPath, Using = "//*[@id='language']/select/option[3]")]
        private IWebElement selectLanguage;

        [FindsBy(How = How.Id, Using = "linkBtnPS4")]
        private IWebElement officalSite;

        [FindsBy(How = How.XPath, Using = "//*[@id='linkBtnPC']/div/a")]
        private IWebElement steamSite;

        [FindsBy(How = How.Id, Using = "acceptBtn")]
        private IWebElement messagebox;

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://www.monsterhunterworld.com/");
        }

        public void SelectLanguage()
        {
            selectLanguage.Click();
        }

        public void OfficalSite()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("linkBtnPS4")));
            officalSite.Click();
        }

        public void SteamSite()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("linkBtnPC")));
            steamSite.Click();
        }

        public void MessageBox()
        {
            messagebox.Click();
        }
    }
}
