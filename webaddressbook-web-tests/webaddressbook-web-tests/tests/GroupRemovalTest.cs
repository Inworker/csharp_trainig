using NUnit.Framework;




namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTest : TestBase
    {
        [Test]
        public void TheDeleteGroupsTest()
        {
            app.Nav.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Nav.GoToGroupPage();
            app.Group.SelectGroup(1);
            app.Group.DeleteGroup();
            app.Nav.GoToGroupPage();
            app.Nav.ClickButtonLogout();
        }
    }
}
