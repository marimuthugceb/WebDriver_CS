using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webdriver_C_NUnit.Pages;

namespace Webdriver_C_NUnit.Framework
{
   public class PageFactory
    {
        private static GoogleHomePage google_home_page;


        public static void initializePageObjects()
        {
            google_home_page = new GoogleHomePage();

        }

        /*** Getter Methods***/
        public static GoogleHomePage googleHomePage()
        {
            return google_home_page;
        }
    }
}
