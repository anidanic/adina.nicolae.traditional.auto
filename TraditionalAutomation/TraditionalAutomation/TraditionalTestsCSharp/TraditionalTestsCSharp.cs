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
    /// elapsed 5h, 20 min
    /// </summary>
    [TestFixture]
    public class TraditionalTestsCSharp : BaseTest
    {
        [Test]
        public void LoginUITest()
        {
            //decide which version/ url you want to use
            bool testVersion1 = false;
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
        public void DataDrivenTest()
        {
            //decide which version/ url you want to use
            bool testVersion1 = true;
            bool showAd = false;
            string url = Utils.GetUrl(testVersion1, showAd);
            //go to that url
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(driver);


            //            Test the following login functionality by entering different values to username and password fields.
            //If you don’t enter the username and password and click the login button, it should throw an error
            //If you only enter the username and click the login button, it should throw an error
            //If you only enter the password and click the login button, it should throw an error
            //If you enter both username(any value) and password(any value), it should log you in.
        }

        [Test]
        public void TableSortTest()
        {
            //decide which version/ url you want to use
            bool testVersion1 = true;
            bool showAd = false;
            string url = Utils.GetUrl(testVersion1, showAd);
            //go to that url
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(driver);

            //Once logged in (use any username and password to login), view the Recent Transactions table.Your test should click on the "Amounts" header, and verify that the column is in ascending order and that each row’s data stayed in tact after the sorting.
        }

        [Test]
        public void CanvasChartTest()
        {
            //decide which version/ url you want to use
            bool testVersion1 = true;
            bool showAd = false;
            string url = Utils.GetUrl(testVersion1, showAd);
            //go to that url
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(driver);

            //Once logged in, click on the "Compare Expenses" button on the toolbar. This will display a bar chart comparing the expenses for the year 2017 and 2018.Assume the values of the chart are coming from a test data and the test data will not change across versions.Validate that the bar chart and representing that data(number of bars and their heights).They should remain the same across versions.Then click on the "Show data for next year" button.This should add the data for the year 2019.Verify that this data set is added for the year 2019.
        }
        [Test]
        public void DynamicContentTest()
        {
            //decide which version/ url you want to use
            bool testVersion1 = true;
            bool showAd = true;
            string url = Utils.GetUrl(testVersion1, showAd);
            //go to that url
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            LoginPage loginPage = new LoginPage(driver);

            //Test for the existence of a display ad that’s dynamic and at times might go missing by using this URL: https://demo.applitools.com/hackathon.html?showAd=true. Log in by entering any username and password. Once logged in, you should see two different "Flash sale" gifs. Make sure both gifs exists.
        }
    }
}
