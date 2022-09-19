using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProject1.PageObj
{
    public class ShopWomenPage
    {
        IWebDriver driver;
        string CartFill = "1";

        public ShopWomenPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //public void Size()
        //{
        //    IWebElement DropDownWomen = driver.FindElement(By.Id("group_1"));
        //    SelectElement SelectDrop = new SelectElement(DropDownWomen);
        //    SelectDrop.SelectByValue("2");
        //}
        public void AddtoCart()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\'add_to_cart\']/button")).Click();
            string actualNo = driver.FindElement(By.ClassName("ajax_cart_no_product")).Text;
            Assert.AreNotEqual(CartFill, actualNo);
        }

    }

}
