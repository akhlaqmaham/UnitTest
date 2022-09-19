using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.PageObj
{
    public class LoginPage
    {
        public IWebDriver driver;
        //public TestContext TestContext { get; set; }
        By Email = By.Id("email");
        By Password = By.Id("passwd");
        By LoginButton = By.Id("SubmitLogin");
        public string Expected = "Maham Akhlaq";

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;   
        }
        //public void EnterEmail()
        //{
        //    driver.FindElement(By.Id("email_create")).SendKeys("akhlaq.maham21@gmail.com");
        //    driver.FindElement(By.Id("SubmitCreate")).Click();
        //}
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"registerdata.xml", "register", DataAccessMethod.Sequential)]
        //public void Register()
        //{
        //    driver.FindElement(By.Id("email_create")).SendKeys(TestContext.DataRow[0].ToString());
        //    driver.FindElement(By.Id("SubmitCreate")).Click();
        //    string actual_reg = driver.FindElement(By.XPath("//*[@id=\'create_account_error\']/ol/li/text()")).Text;
        //    Assert.AreEqual(reg_email, actual_reg);

        //    //radiobutton
        //    IWebElement radio = driver.FindElement(By.XPath("//*[@id=\'id_gender2\']"));
        //    radio.Click();

        //    driver.FindElement(By.Id("customer_firstname")).SendKeys(TestContext.DataRow[1].ToString());
        //    driver.FindElement(By.Id("customer_lastname")).SendKeys(TestContext.DataRow[2].ToString());
        //    driver.FindElement(By.Id("passwd")).SendKeys(TestContext.DataRow[3].ToString());

        //    //dropdown for date of birth
        //    IWebElement DropDownDay = driver.FindElement(By.Id("days"));
        //    SelectElement SelectDay = new SelectElement(DropDownDay);
        //    SelectDay.SelectByValue("20");

        //    IWebElement DropDownMonth = driver.FindElement(By.Id("months"));
        //    SelectElement SelectMonth = new SelectElement(DropDownMonth);
        //    SelectMonth.SelectByValue("5");

        //    IWebElement DropDownYear = driver.FindElement(By.Id("years"));
        //    SelectElement SelectYear = new SelectElement(DropDownYear);
        //    SelectYear.SelectByValue("2000");

        //    driver.FindElement(By.Id("firstname")).SendKeys(TestContext.DataRow[1].ToString());
        //    driver.FindElement(By.Id("lastname")).SendKeys(TestContext.DataRow[2].ToString());
        //    driver.FindElement(By.Id("company")).SendKeys(TestContext.DataRow[4].ToString());
        //    driver.FindElement(By.Id("address1")).SendKeys(TestContext.DataRow[5].ToString());
        //    driver.FindElement(By.Id("address2")).SendKeys(TestContext.DataRow[6].ToString());
        //    driver.FindElement(By.Id("city")).SendKeys(TestContext.DataRow[7].ToString());

        //    IWebElement DropDownState = driver.FindElement(By.Id("id_state"));
        //    SelectElement SelectState = new SelectElement(DropDownState);
        //    SelectState.SelectByValue("9");

        //    driver.FindElement(By.Id("postcode")).SendKeys(TestContext.DataRow[8].ToString());

        //    IWebElement DropDownCountry = driver.FindElement(By.Id("id_country"));
        //    SelectElement SelectCountry = new SelectElement(DropDownCountry);
        //    SelectCountry.SelectByValue("21");

        //    driver.FindElement(By.Id("phone_mobile")).SendKeys(TestContext.DataRow[9].ToString());
        //    driver.FindElement(By.Id("submitAccount")).Click();
        //}


        public void TypeEmail()
        {
            driver.FindElement(Email).SendKeys("akhlaq.maham21@gmail.com");

        }
        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("maham12");
        }
        public void ClickLoginButton()
        {
            driver.FindElement(LoginButton).Click();       
        }
        public void UseratLoginPage()
        {
            string actual= driver.FindElement(By.ClassName("account")).Text;
            Assert.AreEqual(Expected, actual);
        }
        public void LogoutExists()
        {
             Assert.IsTrue(driver.FindElement(By.ClassName("logout")).Displayed);
            
        }
        public Women NavigatetoWomen()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.ClassName("sf-with-ul")).Click();
            return new Women(driver);
            

        }
    }
}
