using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalAutomation.Pages
{
    public class Utils
    {
        IWebDriver driver;
        static string urlForV1 = "https://demo.applitools.com/hackathon.html";
        static string urlForV2 = "https://demo.applitools.com/hackathonV2.html";
        static string showAdParam = "?showAd=true";

        public static string GetUrl(bool testVersion1, bool showAd)
        {
            string url;
            if (testVersion1)
            {
                Console.WriteLine("Version 1 was chosen. This means the before page.");
                url = urlForV1;
            }
            else
            {
                Console.WriteLine("Version 2 was chosen. This means the after page.");
                url = urlForV2;
            }
            if (showAd)
            {
                url = String.Concat(url, showAdParam);
            }
            Console.WriteLine("Url is {0}", url);
            return url;
        }
    }
}
