using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Webdriver_C_NUnit.Framework;

namespace Webdriver_C_NUnit.Tests
{
    public class HomePageTest : BaseTest
    {

        [Test]
        public void DoGoogleSearch()
        {
            googleHomePage().EnterSearchText("selenium");
            googleHomePage().ClickSearchButton();
        }
    }
}
