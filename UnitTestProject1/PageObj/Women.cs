using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Runtime.Remoting.Messaging;

namespace UnitTestProject1.PageObj
{
    public class Women
    {
        IWebDriver driver;

        public Women(IWebDriver driver)
        {
            this.driver = driver;
        }
            
        public void CheckBoxCategories()
        {
            IWebElement y = driver.FindElement(By.Id("layered_category_8"));

            if (y.GetAttribute("checked") == null)
            {
                y.Click(); //if checked
            }
        }
        public void CheckBoxSize()
        {
            IWebElement small = driver.FindElement(By.Id("layered_id_attribute_group_1"));
            if (small.GetAttribute("checked") == null)
            {
                small.Click();
            }
        }
        public void DropDownWomen()
        {
            IWebElement DropDownWomen = driver.FindElement(By.Id("selectProductSort"));
            SelectElement SelectDrop = new SelectElement(DropDownWomen);
            SelectDrop.SelectByValue("price:asc");

        }

        public ShopWomenPage NavigatetoShopWomenPage()
        {
            Thread.Sleep(5000);
            var product = driver.FindElement(By.XPath("//*[@id=\'center_column\']/ul/li[3]/div/div[1]/div/a[1]"));
            Assert.IsTrue(product.Enabled);
            product.Click();
            return new ShopWomenPage(driver);
            
            
        }

    }
}
