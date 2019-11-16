using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalAutomation.Pages
{
    public class SaveFile
    {
        //create folder for taking screenshots, if it does not exist
        public static void CheckFilePath(string Path)
        {
            DirectoryInfo validation = new DirectoryInfo(Path);
            if (!validation.Exists)
            {
                validation.Create();
            }
        }

        //get the time and date with miliseconds
        public static string GetTimeString(bool isMiliseconds)
        {
            StringBuilder timeAndDate = new StringBuilder(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff", CultureInfo.InvariantCulture));
            timeAndDate.Replace("/", "_");
            timeAndDate.Replace(":", "_");
            timeAndDate.Replace(".", "_");
            return timeAndDate.ToString();
        }

        //get the time and date
        public static string GetTimeString()
        {
            StringBuilder timeAndDate = new StringBuilder(DateTime.Now.ToString());
            timeAndDate.Replace("/", "_");
            timeAndDate.Replace(":", "_");
            return timeAndDate.ToString();
        }

        public static void TakesScreenshotWithDate(IWebDriver BrowserInstance, string path, string fileName, ScreenshotImageFormat format, int screenCounter)
        {
            TakesScreenshotWithDate(BrowserInstance, path, fileName, format, screenCounter.ToString());
        }

        public static void TakesScreenshotWithDate(IWebDriver BrowserInstance, string path, bool addDateToPathName, string fileName, ScreenshotImageFormat format, int screenCounter)
        {
            TakesScreenshotWithDate(BrowserInstance, path, addDateToPathName, fileName, format, screenCounter.ToString());
        }

        public static void TakesScreenshotWithDate(IWebDriver BrowserInstance, string path, string fileName, ScreenshotImageFormat format, string counterAndMessage)
        {
            string timeAndDate = GetTimeString();
            CheckFilePath(path);
            ((ITakesScreenshot)BrowserInstance).GetScreenshot().SaveAsFile(String.Format
            ("{0}\\{1}_{2}_{3}.{4}", path, counterAndMessage, fileName, timeAndDate, format));
        }

        public static void TakesScreenshotWithDate(IWebDriver BrowserInstance, string path, bool addDateToPathName, string fileName, ScreenshotImageFormat format, string counterAndMessage)
        {
            if (!addDateToPathName)
            {
                TakesScreenshotWithDate(BrowserInstance, path, fileName, format, counterAndMessage);
            }
            else
            {
                string timeAndDate = GetTimeString();
                path = path + timeAndDate;
                CheckFilePath(path);
                ((ITakesScreenshot)BrowserInstance).GetScreenshot().SaveAsFile(String.Format
                ("{0}\\{1}_{2}.{3}", path, counterAndMessage, fileName, format));
            }
        }
    }
}
