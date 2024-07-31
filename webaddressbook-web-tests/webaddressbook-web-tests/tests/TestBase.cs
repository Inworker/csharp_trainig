using NUnit.Framework;


namespace WebAddressbookTests
{



    public class TestBase
    {


        protected ApplicationManager app;




        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.Nav.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));


        }

        [TearDown]
        protected void TeardownTest()
        {
            app.Stop();
        }

        




  

       






    }
}
