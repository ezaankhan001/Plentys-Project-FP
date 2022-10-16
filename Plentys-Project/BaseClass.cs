using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AventStack.ExtentReports;

namespace Plentys_Project
{
    public class BaseClass
    {
        public static IWebDriver driver;
        public static object wait;
        public static object Settings { get; set; }

        //fucntion for choosing the desired browser
        public static IWebDriver Browsers(String browser)
        {

            if (browser == "chrome")
            {
                ChromeOptions chromeOption = new ChromeOptions();
                chromeOption.AddArguments("start-maximized");
                chromeOption.AddArguments("incognito");
                chromeOption.AddArguments("disable-popup-blocking");
                //chromeOption.AddArguments("headless");
                driver = new ChromeDriver(chromeOption);


                //driver = new ChromeDriver(chromeOption);
            }
            else if (browser == "edge")
            {
                EdgeOptions edgeOption = new EdgeOptions();
                edgeOption.AddArguments("start-maximized");
                edgeOption.AddArguments("-inprivate");
                edgeOption.AddArguments("disable-popup-blocking");
                //edgeOption.AddArguments("headless");
                driver = new EdgeDriver(edgeOption);
            }
            else if (browser == "firefox")
            {
                FirefoxOptions firefoxOption = new FirefoxOptions();
                firefoxOption.AddArguments("start-maximized");
                firefoxOption.AddArguments("newprivate");
                //firefoxOption.AddArguments("disable-popup-blocking");
                driver = new FirefoxDriver(firefoxOption);
            }
            return driver;
        }

        public void Write(By by, string value)
        {
            try
            {
                driver.FindElement(by).SendKeys(value);
                TakeScreenshot(Status.Pass, "Enter Text");
            }
            catch
            {

                TakeScreenshot(Status.Fail, "Entering Text Failed ");
            }
        }
        public void WriteEnter(By by, string value)
        {
            try
            {
                driver.FindElement(by).SendKeys(value + Keys.Enter);
                TakeScreenshot(Status.Pass, "Enter Text");
            }
            catch
            {
                TakeScreenshot(Status.Fail, "Entering Text Failed ");
            }

        }
        public void WriteTab(By by, string value)
        {
            driver.FindElement(by).SendKeys(value + Keys.Tab);
        }
        public void Click(By by)
        {
            try
            {
                driver.FindElement(by).Click();
                TakeScreenshot("Click Element");
            }
            catch (Exception)
            {
                TakeScreenshot(Status.Fail, "Element not Clicked");
            }
        }
        public static void TakeScreenshot(string stepDetail)
        {
            string path = @"C:\Users\HP\source\repos\Plentys-Project\Plentys-Project\extentReport" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(Status.Pass, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\Users\HP\source\repos\Plentys-Project\Plentys-Project\extentReport" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public IWebElement WaitforElement(By by, int timeToReadyElement = 0)
        {
            IWebElement element = null;
            try
            {
                if (timeToReadyElement != 0 && timeToReadyElement.ToString() != null)
                {
                    PlayBackWait(timeToReadyElement * 1000);
                }
                element = driver.FindElement(by);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true && IsClickable(by) == true);
                element = driver.FindElement(by);
            }
            return element;
        }
        public static void AssertAreEqualMethod(By by, string expect)
        {
            string actualText = driver.FindElement(by).Text;
            Assert.AreEqual(expect, actualText);
        }
        public bool IsClickable(By by)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;            }
        }

        public IWebElement findElement(By by)
        {
            return driver.FindElement(by);
        }
       
        public static void PlayBackWait(int milliSeconds)
        {
            Thread.Sleep(milliSeconds);
        }
        public void ReFreshPage()
        {
            driver.Navigate().Refresh();
        }
        public bool IsElementVisible(By by)
        {
            return (findElement(by).Displayed || findElement(by).Enabled) ? true : false;
        }

        //Function for clearing the field
        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }
        //function for opening a URL
        public static void OpenURL(String url)
        {
            driver.Url = url;
        }
        //function for hoveing over an elemnent
        public static void Hover(By by)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(by)).Perform();
        }
        //function for hovering and then clicking
        public static void HoverNClick(By by)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(by)).Click().Perform();
        }

        //function for maximising the screen
        public static void Maximize()

        {
            driver.Manage().Window.Maximize();
        }
        public void CloseBrowser()
        {
            driver.Close();
        }
        public void QuitBrowser()
        {
            driver.Quit();
        }

        public void DropDown(By by, string text)
        {
            IWebElement drpDown = driver.FindElement(by);
            SelectElement dropDownMenu = new SelectElement(drpDown);
            dropDownMenu.SelectByText(text);
        }

        private bool IsPageReady(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver)
            .ExecuteScript("return document.readyState")
            .Equals("complete");
        }

        public string GetText(By by)
        {
            IWebElement gettext = driver.FindElement(by);
            string text = gettext.GetAttribute("value");
            return text;
        }
        public static void ImplicitWait(int value)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }
        public static void Scroll()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //js.ExecuteScript("window.scrollBy(argument[0].argument[1]);", value, value1);
            js.ExecuteScript("window.scrollBy(0,600);");
        }
        public static void ScrollToElement(By by)
        {
            var scrollToElement = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
        }

        public static void ScrollBy(int value, int value1)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(argument[0],argument[1]);", value, value1);
            //js.ExecuteScript("window.scrollBy(0,600);");
        }

        public void scrollBottom()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.ScrollTo(0,document" + "Body" + ".scrollHeight)");
        }
        
        public void ScrollPageUp()
        {
            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            scroller.ExecuteScript("window.scrollTo(0, document." + "head" + ".scrollHeight);");
        }
        public void SwitchDefault()
        {
            driver.SwitchTo().DefaultContent();
        }
        public void SwitchFrame(By by)
        {
            driver.SwitchTo().Frame(driver.FindElement(by));
        }
        //
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}