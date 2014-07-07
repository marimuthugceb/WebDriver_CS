using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Webdriver_C_NUnit.Framework
{
    public class WebUi : Driver
    {
        private const int DEFAULT_WAIT = 10;

        protected void Open(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        protected void Type(By by, String testdata)
        {
            GetElement(by).SendKeys(testdata);
        }

        protected void Click(By locator)
        {
            driver.FindElement(locator).Click();
        }

        protected void DismissAlert()
        {
            var alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

        protected string GetAlertMessage()
        {
            var alert = driver.SwitchTo().Alert();
            return alert.Text;
        }


        protected IWebElement GetElement(By locator)
        {
            return FindElementWithWait(locator, DEFAULT_WAIT);

        }

        private static IWebElement FindElementWithWait(By by, int defaultWait)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(defaultWait));
            return wait.Until(drv => driver.FindElement(by));
        }



    }
}
