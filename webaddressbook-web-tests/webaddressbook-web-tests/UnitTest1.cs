using NUnit.Framework;
using System;
using webaddressbook_web_tests;
using Assert = Xunit.Assert;


namespace webaddressbook_web_tests
{
    
    public class Untited
    {
        [Test]
        public void Test1()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.Equal(s1.getSize(), 5);
            Assert.Equal(s2.getSize(), 10);
            Assert.Equal(s2.getSize(), 10);
            s3.setSize(15);
            Assert.Equal((int)s1.getSize(), 15);
        }
    }
}
//Тут коммент для коммита