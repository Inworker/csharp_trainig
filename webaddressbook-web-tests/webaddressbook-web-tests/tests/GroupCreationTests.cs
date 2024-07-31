using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       

        [Test]
        public void GroupCreationTest()
        {
            app.Nav.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Nav.GoToGroupPage();
            app.Group.CreationNewGroup();
            app.Group.FillGropForm(new GroupData ("aaa", "ddd", "qwfqw"));
            app.Group.ClickButtonSubmit();
            app.Group.ClickButtonGroup();
            app.Nav.ClickButtonLogout();
        }

              
}
}
