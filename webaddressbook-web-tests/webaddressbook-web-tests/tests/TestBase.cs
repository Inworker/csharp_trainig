﻿using NUnit.Framework;


namespace WebAddressbookTests
{



    public class TestBase
    {


        protected ApplicationManager app;




        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();


        }

        [TearDown]
        protected void TeardownTest()
        {
            app.Stop();
        }

        




  

       






    }
}
