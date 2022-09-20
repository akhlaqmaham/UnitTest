using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.PageObj;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace UnitTestProject1.TestAuto
{
    [TestClass]
    public class TestBase : AutomationBase
    {
        [TestMethod]
        public void LoginTest()
        {
            var home = new HomePage(driver);
            var loginpage = home.NavigatetoLogin();
            loginpage.TypeEmail();
            loginpage.TypePassword();
            loginpage.ClickLoginButton();
            loginpage.UseratLoginPage();
            loginpage.LogoutExists();
            Thread.Sleep(5000);

            var women = loginpage.NavigatetoWomen();
            women.CheckBoxCategories();
            women.CheckBoxSize();
            women.DropDownWomen();
        
            var womenpage = women.NavigatetoShopWomenPage();
            womenpage.AddtoCart();
            Thread.Sleep(5000);
        }
    }
}
