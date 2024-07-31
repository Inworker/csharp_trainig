using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;


namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase


    {
        public GroupHelper(ApplicationManager manager) : base(manager)
        {

        }

        public GroupHelper DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;

        }

        public GroupHelper CreateGroup(GroupData group)
        {
            
            CreationNewGroup();
            FillGropForm(group);
            ClickButtonSubmit();
            ClickButtonGroup();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name = 'selected[]'])[" + index + "]")).Click();
            return this;

        }



        public GroupHelper CreationNewGroup()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }



        public GroupHelper ClickButtonGroup()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;

        }

        public GroupHelper ClickButtonSubmit()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;

        }

        public GroupHelper FillGropForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;

        }


    }
}
