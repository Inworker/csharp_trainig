using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("aaa");
            group.Header = "dddd";
            group.Footer = "sss";

            app.Nav.GoToGroupPage();
            app.Group.CreateGroup(group);
            app.Nav.ClickButtonLogout();
        }
        
        [Test]
        public void EmptyGroupCreationTest2()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Nav.GoToGroupPage();
            app.Group.CreateGroup(group);
            app.Nav.ClickButtonLogout();
        }

    }
}
