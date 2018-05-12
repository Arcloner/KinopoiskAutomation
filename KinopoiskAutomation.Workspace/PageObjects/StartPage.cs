using KinopoiskAutomation.Framework.Drivers;
using KinopoiskAutomation.Framework.PageObjects.Base;
using KinopoiskAutomation.Workspace.PageObjects.Interfaces;
using OpenQA.Selenium;
using System;

namespace KinopoiskAutomation.Workspace.PageObjects
{
    public class StartPage : BasePage, IStartPage
    {
        public StartPage(Guid DriverKey) : base(DriverKey){}

        private IWebElement searchInput => Driver.GetDriver(DriverKey).FindElementByXPath("//div[contains(@class,'head')]/input[@placeholder]");

        private IWebElement searchButton => Driver.GetDriver(DriverKey).FindElementByXPath("//div[contains(@class,'head')]//button[contains(@class,'search')]");

        public void ClickSearchButton()
        {
            searchButton.Click();
        }

        public void SendKeysToSearchInput(string keys)
        {
            searchInput.SendKeys(keys);
        }
    }
}
