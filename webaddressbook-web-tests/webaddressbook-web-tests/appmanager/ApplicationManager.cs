using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webaddressbook_web_tests;
using Assert = NUnit.Framework.Assert;

namespace WebAddressbookTests
{
     public class ApplicationManager
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;
        private bool acceptNextAlert = true;

        protected LoginHelper loginHelper;
        protected NavigationHelper nav;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";
            
            loginHelper = new LoginHelper(driver);
            nav = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);

        }
        public LoginHelper Auth
        {  get { return loginHelper; } }

        public NavigationHelper Nav
        {  get { return nav; } }

        public GroupHelper Group { get { return groupHelper; } }
        public ContactHelper Contact { get {return contactHelper;} }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
