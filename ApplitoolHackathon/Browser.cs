using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
namespace ApplitoolHackathonHelpers 
{
    public class Browser : TestBase, IDisposable
    {

        public IWebDriver driver;

        private const string DRIVER = "C:\\applitoolTest";
        //private const string URL = "https://demo.applitools.com/hackathon.html";
        //private const string URL = "https://demo.applitools.com/hackathonV2.html";
       //private const string URL = "https://demo.applitools.com/hackathon.html?showAd=true";
       private const string URL = "https://demo.applitools.com/hackathonV2.html?showAd=true";
        private const int PAGELOAD = 10;
        private const int IMPLICITWAIT = 10;

        public string GetAttributes(string locator)
        {
            var element = driver.FindElement(By.XPath(locator));

            var script = element.GetAttribute("innerHTML");
            return script;
        }

        public  Browser()
        {

            driver = new ChromeDriver(DRIVER);
            driver.Navigate().GoToUrl(URL);
            driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, PAGELOAD);
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, IMPLICITWAIT);
            driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);

        }

        public static Browser CreateBrowser()
        {
            if (Browser==null)
            {
                Browser = new Browser();
            }
            return Browser;
        }

        public void Close()
        {
            driver.Close();
        }

        public void Dispose()
        {
            Close();
            driver.Dispose();
        }

        /// <summary>
        /// Gets the Title of the page
        /// </summary>
        /// <returns></returns>
        public string GetTitle()
        {
            var title = driver.Title;
            Assert.IsNotNull(title);
            return title;
        }

        /// <summary>
        /// Gets the value of the specified webelement
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public string GetValue(string locator)
        {
            //TODO check if element is null
            IWebElement element = driver.FindElement(By.XPath(locator));
            var value = element.Text;
            Assert.IsNotNull(value);
            return value;
        }

        /// <summary>
        /// detects if element is dispayed on the screen
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool IsElementOnPage(string locator)
        {
            IWebElement element = driver.FindElement(By.XPath(locator));
            return element.Displayed && element.Enabled;
        }

        /// <summary>
        /// Clicking an element
        /// </summary>
        /// <param name="element"></param>
        public void Click(string locator)
        {
            IWebElement element = driver.FindElement(By.XPath(locator));
            element.Click();
                
        }

        /// <summary>
        /// Setting a value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public void SetValue(string locator, string value)
        {
            IWebElement element = driver.FindElement(By.XPath(locator));
            element.SendKeys(value);
        }

        public List<string> GetTable(string locator)
        {
           
            List<string> track = new List<string>();

            ///TBD in future consider this to be a dynamic table and code, acc. also consider that the type can be different,currently returning last column
           
                for (int k = 1; k < 7; k++)
                {
                    track.Add(driver.FindElement(By.XPath(locator + $"//tbody//tr[{k}]//td[{5}]//span")).Text);
                }
               
            return track;
        }
    }
}
