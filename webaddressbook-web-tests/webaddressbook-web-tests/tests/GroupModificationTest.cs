using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;


namespace WebAddressbookTests

{
    [TestFixture]
    class GroupModificationTest:TestBase
    {
        [Test]
        public void GroupModificationTests()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = "qqq";
            newData.Footer = "www";
            app.Group.Modify(1, newData);

        }


    }
}
