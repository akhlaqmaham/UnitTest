using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V102.Console;
using OpenQA.Selenium.DevTools.V102.SystemInfo;
using System;

namespace UnitTestProject1
{
    public class AutomationBase
    {
        public IWebDriver driver;

        [TestInitialize]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://automationpractice.com/index.php";
        }
        [TestCleanup]
        public void Close()
        {
            driver.Close();
        }
    }
}
            //string text= driver.FindElement(By.ClassName("alert alert-danger")).Text;
            //Assert.AreEqual(message, text);

            //Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            //ss.SaveAsFile("Image.png", ScreenshotImageFormat.Png);

