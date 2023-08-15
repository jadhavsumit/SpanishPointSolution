using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using SpanishPoint.pageObjects;
using SpanishPoint.Utilities;

namespace SpanishPoint
{
    public class Tests : BaseClass
    {

        [Test]
        public void Test1()
        {
       
            HomePagePO homePage = new HomePagePO(getDriver());
            ModernWorkPO modernWork = new ModernWorkPO(getDriver());

            homePage.getBtnAcceptAll().Click();

            Actions actions = new Actions(getDriver());
            actions.MoveToElement(homePage.getddlSolutionAndServices()).Perform();

            homePage.getbtnModernWork().Click();
            modernWork.gettbContentCollaboration().Click();

            string actualText = modernWork.getParagraphText().Text;

            Assert.That(actualText, Contains.Substring(actualText));

        }
    }
}