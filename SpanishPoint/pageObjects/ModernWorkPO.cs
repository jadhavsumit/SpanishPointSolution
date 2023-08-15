using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SpanishPoint.pageObjects
{
    public class ModernWorkPO
    {
        private IWebDriver driver;
        public ModernWorkPO(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //PO Factory
        [FindsBy(How = How.XPath, Using = "//span[text()='Content & Collaboration']")]
        private IWebElement tbContentCollaboration;
        [FindsBy(How = How.XPath, Using = "//p[starts-with(., 'Spanish Point customers tell')]")]
        private IWebElement Text;

        public IWebElement gettbContentCollaboration() => tbContentCollaboration;
        public IWebElement getParagraphText() => Text;
    }
}
