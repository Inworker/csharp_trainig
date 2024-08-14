using NUnit.Framework;




namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTest : TestBase
    {
        [Test]
        public void TheDeleteGroupsTest()
        {

            app.Nav.GoToGroupPage();
            app.Group.Remove(1);

        }
    }
}
