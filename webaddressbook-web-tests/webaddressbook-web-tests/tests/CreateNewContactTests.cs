using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Assert = NUnit.Framework.Assert;


namespace WebAddressbookTests
{
    [TestFixture]
    public class CreateNewContactTests : TestBase
    {

        [Test]
        public void CreateNewContactTest()
        {
            app.Nav.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contact.CreateNewContact(new ContactData ("firstName","LastName"));
            app.Nav.ClickButtonLogout();
        }

    }
}
