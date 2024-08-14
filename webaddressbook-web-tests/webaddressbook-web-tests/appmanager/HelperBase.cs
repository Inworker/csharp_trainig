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

        public GroupHelper Remove(int v)
        {
            manager.Group
                            .SelectGroup(1)
                            .DeleteGroup();
            manager.Nav
                .GoToGroupPage()
                .ClickButtonLogout();
            return (GroupHelper)this;    
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Nav.GoToGroupPage();
            manager.Group.SelectGroup(v);
            manager.Group.InitGroupModification();
            manager.Group.FillGropForm(newData);
            manager.Group.SubmitGroupModification();
            manager.Nav.GoToGroupPage();
            return (GroupHelper)this;
        }
    }
}