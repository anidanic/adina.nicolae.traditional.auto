using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalAutomation.Pages
{
    public class GetBrowser
    {
        public static IWebDriver GetDriver()
        {
            ChromeOptions co = new ChromeOptions();
            co.AddArguments("--start-maximized", "--incognito");
            //co.EnableMobileEmulation("Galaxy S5");
            return new ChromeDriver(co);
        }
    }
}
