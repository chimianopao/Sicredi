using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sicredi.Base
{
    public class BasePageViewMap
    {
        protected IWebDriver browser;

        public BasePageViewMap()
        {
            browser = Driver.Browser;
        }

        protected IWebElement GetWebElementById(string id)
        {
            return browser.FindElement(By.Id(id));
        }

        protected IWebElement GetWebElementByXPath(string xPath)
        {
            return browser.FindElement(By.XPath(xPath));
        }
        
        protected IWebElement GetWebElementByClassName(string className)
        {
            return browser.FindElement(By.ClassName(className));
        }
    }
}
