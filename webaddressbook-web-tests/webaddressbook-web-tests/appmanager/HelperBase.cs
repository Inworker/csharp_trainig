using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System.Text;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;
using webaddressbook_web_tests;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        private ApplicationManager manager;
        public HelperBase(ApplicationManager manager)

        {
            this.manager = manager;
            this.driver = manager.Driver;
        }
    }
}