using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TraditionalAutomation.Pages;

namespace TraditionalAutomation.TraditionalTestsCSharp
{
    [TestFixture]
    public class TraditionalTestsCSharp : BaseTest
    {
        [Test]
        public void LoginUITest()
        {
            string url = "https://demo.applitools.com/hackathon.html";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            Console.WriteLine("Url is {0}", url);
            LoginPage loginPage = new LoginPage();
            Assert.IsTrue(loginPage.PageNameIsDisplayed, "Issue with page name display");
            Assert.IsTrue(loginPage.UsernameIsDisplayed, "Issue with page name display");
            Assert.IsTrue(loginPage.PasswordIsDisplayed, "Issue with page name display");
            Assert.IsTrue(loginPage.LoginButtonIsDisplayed, "Issue with page name display");
            Assert.IsTrue(loginPage.RememberMeIsDisplayed, "Issue with page name display");
            Assert.IsTrue(loginPage.RememberMeCheckboxIsEnabled, "Issue with page name display");
            Assert.AreEqual(loginPage.ExpectedPageName,loginPage.PageNameText, "Issue with page name display");
            Assert.AreEqual(loginPage.ExpectedLoginButton, loginPage.LoginButtonText, "Issue with page name display");
            Assert.IsTrue(loginPage.LabelsAreConfirmed(), "Issue with page name display");
            Assert.IsTrue(loginPage.ImagesAreConfirmed(), "Issue with page name display");
            Assert.IsTrue(loginPage.PlaceHoldersAreConfirmed(), "Issue with page name display");
        }

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
        public void TableSortTest()
        {
            string url = "https://www.google.com/";
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            Console.WriteLine("Url is {0}", url);
        }
    }
}
