using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TraditionalAutomation.TraditionalTestsCSharp
{
    [TestFixture]
    public class TraditionalTestsCSharp : BaseTest
    {
        [Test]
        public void CanvasChartTest()
        {
            string url = "https://www.google.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            Console.WriteLine("Url is {0}", url);
        }

        [Test]
        public void DataDrivenTest()
        {
            string url = "https://www.google.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            Console.WriteLine("Url is {0}", url);
        }

        [Test]
        public void DynamicContentTest()
        {
            string url = "https://www.google.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            Console.WriteLine("Url is {0}", url);
        }

        [Test]
        public void LoginUITest()
        {
            string url = "https://www.google.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            Console.WriteLine("Url is {0}", url);
        }
        [Test]
        public void TableSortTest()
        {
            string url = "https://www.google.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            Console.WriteLine("Url is {0}", url);
        }
    }
}
