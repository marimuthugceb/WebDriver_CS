using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Webdriver_C_NUnit.Framework
{
   public class Driver
    {
        public static IWebDriver driver;


        public static IWebDriver getInstance()
        {
            driver = new FirefoxDriver();
            return driver;

        }
    }
}
