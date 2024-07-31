using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.Text;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace WebAddressbookTests

{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        {
            this.baseURL = baseURL;
        }
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void GoToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        public void ClickButtonLogout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}
