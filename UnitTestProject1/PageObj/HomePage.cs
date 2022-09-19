using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObj
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage NavigatetoLogin()
        {
            driver.FindElement(By.ClassName("login")).Click();
            return new LoginPage(driver);

        }
    }
}
