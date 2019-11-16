using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraditionalAutomation.Pages
{
    public class LoginPage
    {
        //items
        IWebDriver driver;
        IWebElement PageName => driver.FindElement(By.TagName("h4"));
        IWebElement Username => driver.FindElement(By.Id("username"));
        IWebElement Password => driver.FindElement(By.Id("password"));
        IWebElement LoginButton => driver.FindElement(By.Id("log-in"));
        IWebElement RememberMe => driver.FindElement(By.ClassName("form-check-label"));
        IWebElement RememberMeCheckbox => driver.FindElement(By.ClassName("form-check-input"));
        IList<IWebElement> Labels => driver.FindElements(By.TagName("label"));
        IList<IWebElement> Images => driver.FindElements(By.TagName("img"));
        string[] ExpectedLabels = { "Username", "Password", "Remember Me" };
        string[] ExpectedImages = { "img/logo-big.png", "img/social-icons/twitter.png", "img/social-icons/facebook.png", "img/social-icons/linkedin.png" };
        public string ExpectedPageName = "Login Form";
        public string ExpectedLoginButton = "Log In";
        string[] ExpectedPlaceHolders = { "Enter your username", "Enter your password" };

        //properties
        public bool PageNameIsDisplayed => PageName.Displayed;
        public bool UsernameIsDisplayed => Username.Displayed;
        public bool PasswordIsDisplayed => Password.Displayed;
        public bool LoginButtonIsDisplayed => LoginButton.Displayed;
        public bool RememberMeIsDisplayed => RememberMe.Displayed;
        public bool RememberMeCheckboxIsEnabled => RememberMeCheckbox.Enabled;
        public string PageNameText => PageName.Text;
        public string LoginButtonText => LoginButton.Text;

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

        //methods
        public bool LabelsAreConfirmed()
        {
            bool isConfirmed = (Labels.Count == ExpectedLabels.Length);
            if (!isConfirmed)
            {
                Console.WriteLine("Mismatch in the number of labels. Expected {0} and found {1}", ExpectedLabels.Length, Labels.Count);
            }
                for (int i = 0; i < Labels.Count; i++)
                {
                    isConfirmed = isConfirmed && Labels[i].Displayed && (Labels[i].Text == ExpectedLabels[i]);
                    if (!isConfirmed)
                    {
                        Console.WriteLine("Issue with the label for {0}. It has Display {1} and Text {2}", ExpectedLabels[i], Labels[i].Displayed, Labels[i].Text);
                    }
                }
                return isConfirmed;
        }

        public bool ImagesAreConfirmed()
        {
            bool isConfirmed = (Images.Count == ExpectedImages.Length);
            if (!isConfirmed)
            {
                Console.WriteLine("Mismatch in the number of images. Expected {0} and found {1}", ExpectedImages.Length, Images.Count);
            }
            for (int i = 0; i < Images.Count; i++)
                {
                    string imageSrc = Images[i].GetAttribute("src");
                int index = imageSrc.IndexOf("img/");
                if (index > 0)
                {
                    imageSrc = imageSrc.Substring(index);
                }
                isConfirmed = isConfirmed && Images[i].Displayed && (imageSrc == ExpectedImages[i]);
                    if (!isConfirmed)
                    {
                        Console.WriteLine("Issue with the image with src for {0}. It has Displayed {1} and Text {2}", ExpectedImages[i], Images[i].Displayed, imageSrc);
                    }
                }
                return isConfirmed;
        }

        public bool PlaceHoldersAreConfirmed()
        {
            string[] PlaceHolders = new string[2];
            PlaceHolders[0] = Username.GetAttribute("placeholder");
            PlaceHolders[1] = Password.GetAttribute("placeholder");
            bool isConfirmed = (PlaceHolders.Length == ExpectedPlaceHolders.Length);
            if (!isConfirmed)
            {
                Console.WriteLine("Mismatch in the number of placeholders. Expected {0} and found {1}", ExpectedPlaceHolders.Length, PlaceHolders.Length);
            }
            for (int i = 0; i < PlaceHolders.Length; i++)
                {
                    isConfirmed = isConfirmed && (PlaceHolders[i] == ExpectedPlaceHolders[i]);
                    if (!isConfirmed)
                    {
                        Console.WriteLine("Issue with the placeholder for {0}. It has Text {1}", ExpectedPlaceHolders[i], PlaceHolders[i]);
                    }
                }
                return isConfirmed;
        }
    }
}
