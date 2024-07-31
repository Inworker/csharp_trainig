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
        public HelperBase(IWebDriver driver)

        {
            this.driver = driver;
        }
    }
}