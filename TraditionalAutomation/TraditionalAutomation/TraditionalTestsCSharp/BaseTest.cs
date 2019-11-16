using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TraditionalAutomation.Pages;

namespace TraditionalAutomation.TraditionalTestsCSharp
{
    /// <summary>
    /// elapsed 2h
    /// now 11.30 - 13.00
    /// </summary>
    [TestFixture]
    public class BaseTest
    {
        public static IWebDriver driver;
        public static string screenshotsPath = @"D:\Screenshots";
        public string testScreenshotsPath;

        [OneTimeSetUp]
        public void BeforeAll()
        {
            Console.WriteLine("This is the start");
            string dir = TestContext.CurrentContext.TestDirectory;
            Console.WriteLine("The location for the Tests folder in this framework is {0}", dir);
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            Console.WriteLine("You can find all the screenshots at {0}", screenshotsPath);
            Console.WriteLine("End All");
        }


        [SetUp]
        //get driver, before each test
        public void SetupTests()
        {
            Console.WriteLine("This is the setup, before each test");
            driver = GetBrowser.GetDriver();
            string testFixtureName = TestContext.CurrentContext.Test.ClassName;
            testScreenshotsPath = Path.Combine(screenshotsPath, testFixtureName);
            SaveFile.CheckFilePath(testScreenshotsPath);
        }

        [TearDown]
        //quit, after each test
        public void CloseBrowser()
        {
            Console.WriteLine("This is the teardown, after each test");
            Thread.Sleep(1000);
            TestStatus testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            string stk = TestContext.CurrentContext.Result.StackTrace;
            Console.WriteLine("Tests ended with status {0} and stack trace {1}.", testStatus, stk);
            //take a screenshot
            string testName = TestContext.CurrentContext.Test.Name;
            //string timeAndDate = SaveFile.GetTimeString(true);
            SaveFile.TakesScreenshotWithDate(driver, testScreenshotsPath, testName, ScreenshotImageFormat.Jpeg, 1);
            // close the browser
            driver.Quit();
        }
    }
}
