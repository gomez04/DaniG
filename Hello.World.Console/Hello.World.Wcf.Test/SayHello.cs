using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello.World.Wcf.Test.MyHelloWorldService;

namespace Hello.World.Wcf.Test
{
    [TestClass]
    public class SayHello
    {
        [TestMethod]
        public void HelloDearUser()
        {
            // initialize
            string userName = "Dear User";
            string expectedResult = "Hello Dear User";
            string realResult;
            HelloWorldClient myService = new HelloWorldClient();

            // test body
            realResult = myService.SayHello(userName);

            // assert
            Assert.AreEqual(expectedResult, realResult);
        }

        [TestMethod]
        public void HelloEmptyUser()
        {
            // initialize
            string userName = "";
            string expectedResult = "Hello ";
            string realResult;
            HelloWorldClient myService = new HelloWorldClient();

            // test body
            realResult = myService.SayHello(userName);

            // assert
            Assert.AreEqual(expectedResult, realResult);
        }

        [TestMethod]
        public void HelloNull()
        {
            // initialize
            string userName = null;
            string expectedResult = "Hello ";
            string realResult;
            HelloWorldClient myService = new HelloWorldClient();

            // test body
            realResult = myService.SayHello(userName);

            // assert
            Assert.AreEqual(expectedResult, realResult);
        }
    }
}
