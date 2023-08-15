using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpanishPoint.pageObjects
{
    public class HomePagePO
    {
        private IWebDriver driver;
        public HomePagePO(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //PO Factory
        [FindsBy(How = How.Id, Using = "wt-cli-accept-btn")]
        private IWebElement BtnAcceptAll;

        [FindsBy(How = How.Id, Using = "cookie-law-info-bar")]
        private IWebElement PopUp;

        [FindsBy(How = How.Id, Using = "menu-item-30711")]
        private IWebElement ddlSolutionAndServices;

        [FindsBy(How = How.Id, Using = "menu-item-23119")]
        private IWebElement btnModernWork;

        //menu-item-23119

        public IWebElement getBtnAcceptAll() => BtnAcceptAll;
        public IWebElement getPopUp() => PopUp;
        public IWebElement getddlSolutionAndServices() => ddlSolutionAndServices;
        public IWebElement getbtnModernWork() => btnModernWork;

    }
}
