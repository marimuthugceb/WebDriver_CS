using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Webdriver_C_NUnit.Framework;

namespace Webdriver_C_NUnit.Pages
{
    public class GoogleHomePage : WebUi
    {
        private static By searchBox = By.Name("q");
        private static By searchButton = By.Name("btnG");


        public void EnterSearchText(String searchText)
        {
            Type(searchBox, searchText);

        }

        public void ClickSearchButton()
        {
            Click(searchButton);
        }
    }
}
