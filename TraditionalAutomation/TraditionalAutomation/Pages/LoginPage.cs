using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalAutomation.Pages
{
    /// <summary>
    /// start hour 10.30
    /// </summary>
    public class LoginPage
    {
        IWebDriver driver;
        IWebElement PageName => driver.FindElement(By.ClassName("auth-header"));
        IWebElement Username => driver.FindElement(By.Id("username"));
        IWebElement Password => driver.FindElement(By.Id("password"));
        IWebElement LoginButton => driver.FindElement(By.Id("log-in"));
        IWebElement RememberMe => driver.FindElement(By.ClassName("form-check-label"));
        IWebElement RememberMeCheckbox => driver.FindElement(By.ClassName("form-check-input"));
        IWebElement Twitter => driver.FindElement(By.ClassName("loginlink"));
        IWebElement Facebook => driver.FindElement(By.ClassName("loginlink"));
        IWebElement Linkedin => driver.FindElement(By.ClassName("loginlink"));

        /// <summary>
        /// constructor for LoginPage
        /// </summary>
        /// <returns>
        /// it's a constructor
        /// </returns>
        public LoginPage()
        {
        }

        /// <summary>
        /// constructor for LoginPage
        /// </summary>
        /// <param name="driver"> an IWebDriver with the input for the driver</param>
        /// <returns>
        /// it's a constructor
        /// </returns>
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
