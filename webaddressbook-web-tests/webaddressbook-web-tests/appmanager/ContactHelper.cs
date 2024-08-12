using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAddressbookTests;

namespace webaddressbook_web_tests
{
    public class ContactHelper : HelperBase
    {
        
        public ContactHelper(ApplicationManager manager) : base(manager)
        {

        }

        public void CreateNewContact(WebAddressbookTests.ContactData contact)
        {
            AddContact();
            ClickFrameFirstName();
            ClearFirstName();
            EnterFirstName(contact);
            ClickFrameLastName();
            ClearFrameLastName();
            EnterLastName(contact);
            ClickButtonSubmit();
        }

        public ContactHelper ClickButtonSubmit()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;

        }

        public ContactHelper EnterLastName(ContactData contact)
        {
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            return this;

        }

        public ContactHelper ClearFrameLastName()
        {
            driver.FindElement(By.Name("lastname")).Clear();
            return this;

        }

        public ContactHelper ClickFrameLastName()
        {
            driver.FindElement(By.Name("lastname")).Click();
            return this;

        }

        public ContactHelper EnterFirstName(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            return this;

        }

        public ContactHelper ClearFirstName()
        {
            driver.FindElement(By.Name("firstname")).Clear();
            return this;

        }

        public ContactHelper ClickFrameFirstName()
        {
            driver.FindElement(By.Name("firstname")).Click();
            return this;

        }

        public ContactHelper AddContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;

        }
    }
}
