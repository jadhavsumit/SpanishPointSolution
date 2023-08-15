using System;
using System.Configuration;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SpanishPoint.Utilities
{
    public class BaseClass
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            //Configurations
            String browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.spanishpoint.ie/";
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                break;

                case "Firefox":
                new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
                break;
            }
        }

        public IWebDriver getDriver()
        {
            return driver;
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
