﻿using OpenQA.Selenium;
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
        public GroupHelper(IWebDriver driver) : base(driver)
        {

        }

        public void DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }

        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name = 'selected[]'])[" + index + "]")).Click();
        }



        public void CreationNewGroup()
        {
            driver.FindElement(By.Name("new")).Click();
        }



        public void ClickButtonGroup()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void ClickButtonSubmit()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FillGropForm(GroupData group)
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
        }


    }
}
