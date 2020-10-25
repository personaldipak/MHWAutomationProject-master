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
    class BuyNowPage
    {
        private IWebDriver driver;

        public BuyNowPage(IWebDriver driver)
        {
            this.driver = driver;
            //this initElements method will create all the webelements
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/a")]
        private IWebElement buynow;

        [FindsBy(How = How.XPath, Using = "//*[@id='tabNav']/ul/li[2]")]
        private IWebElement existingOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ExistingUser']/div/div[1]/div/div[3]/div[2]/a")]
        private IWebElement buyNowButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='platformList']/li[3]")]
        private IWebElement steamOption;

        [FindsBy(How = How.XPath, Using = "//*[@id='ExistingUser']/div/div/div/div/p")]
        private IWebElement steamMessage;

        public void BuyNow()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/a")));
            buynow.Click();
        }

        public void ExistingOption()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='tabNav']/ul/li[2]")));
            existingOption.Click();
        }

        public void BuyNowButton()
        {
            buyNowButton.Click();
        }

        public void SteamOption()
        {
            steamOption.Click();
        }

        public string SteamMessage()
        {
           return steamMessage.Text;
        }
    }
}
