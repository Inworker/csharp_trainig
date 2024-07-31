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
        private ApplicationManager manager;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
            this.manager = manager; 

        }
        public NavigationHelper OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
            return this;
        }
        public NavigationHelper GoToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public NavigationHelper ClickButtonLogout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
                
        }

    }
}
