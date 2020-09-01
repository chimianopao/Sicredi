using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sicredi.Base
{
    public static class Driver
    {
        private static WebDriverWait wait;

        private static IWebDriver browser;

        private static Actions actions;

        public static IWebDriver Browser
        {
            get
            {
                if (browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                }
                return browser;
            }
            private set => browser = value;
        }

        public static WebDriverWait BrowserWait
        {
            get
            {
                if (wait == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return wait;
            }
            private set => wait = value;
        }

        public static Actions SeleniumActions
        {
            get
            {
                if (actions == null || browser == null)
                {
                    throw new NullReferenceException("The WebDriver actions instance was not initialized. You should first call the method Start.");
                }
                return actions;
            }
            private set => actions = value;
        }

        public static void StartBrowser(int defaultTimeOut = 60)
        {
            Browser = new ChromeDriver();

            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(240));
            SeleniumActions = new Actions(Browser);
            Browser.Manage().Window.Maximize();
        }

        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }

        public static IWebElement FindElement(By by)
        {
            return browser.FindElement(by);
        }

        public static void Wait(int tempo)
        {
            Thread.Sleep(tempo);
        }
    }
}
