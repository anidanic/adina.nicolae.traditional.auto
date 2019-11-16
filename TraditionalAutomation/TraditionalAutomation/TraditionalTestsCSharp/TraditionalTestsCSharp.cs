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
    /// <summary>
    /// elapsed 3h, 20 min
    /// now 11.30
    /// </summary>
    [TestFixture]
    public class TraditionalTestsCSharp : BaseTest
    {
        [Test]
        public void LoginUITest()
        {
            //decide which version/ url you want to use
            bool testVersion1 = true;
            bool showAd = false;
            string url = Utils.GetUrl(testVersion1, showAd);
            //go to that url
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(driver);
            Assert.Multiple(() =>
            {
                Assert.IsTrue(loginPage.PageNameIsDisplayed, "Issue with page name display");
                Assert.IsTrue(loginPage.UsernameIsDisplayed, "Issue with username display");
                Assert.IsTrue(loginPage.PasswordIsDisplayed, "Issue with password display");
                Assert.IsTrue(loginPage.LoginButtonIsDisplayed, "Issue with login button display");
                Assert.IsTrue(loginPage.RememberMeIsDisplayed, "Issue with remember me display");
                Assert.IsTrue(loginPage.RememberMeCheckboxIsEnabled, "Issue with the checbox for remember me");
                Assert.AreEqual(loginPage.ExpectedPageName, loginPage.PageNameText, "Issue with the text for page name");
                Assert.AreEqual(loginPage.ExpectedLoginButton, loginPage.LoginButtonText, "Issue with the text for login button");
                Assert.IsTrue(loginPage.LabelsAreConfirmed(), "Issue with the text for the labels");
                Assert.IsTrue(loginPage.ImagesAreConfirmed(), "Issue with the text for the images");
                Assert.IsTrue(loginPage.PlaceHoldersAreConfirmed(), "Issue with the text for the placeholders");
            });
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
