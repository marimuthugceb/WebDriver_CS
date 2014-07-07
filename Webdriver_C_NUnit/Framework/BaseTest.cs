using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Webdriver_C_NUnit.Framework
{
    public class BaseTest : PageFactory
    {
        IWebDriver driver = null;
        private static readonly string AppUrl = ConfigurationManager.AppSettings["AppUrl"];

        [SetUp]
        public void LaunchApp()
        {
            Initialize();
            ClearCookies();
            GoToHomePage();
        }


        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

        public void Initialize()
        {
            driver = Driver.getInstance();
            initializePageObjects();
        }

        public void ClearCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(AppUrl);
        }


    }
}
