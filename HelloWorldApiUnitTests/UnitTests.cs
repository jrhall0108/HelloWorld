using HelloWorldApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldApiUnitTests
{
    [TestClass]
    public class UnitTests
    {
        private static IMessageProvider messageProvider;
        private static string message;
        private static string expectedResult = "Hello World";

        /// <summary>
        /// Test Methods for the various input types
        /// </summary>
        [TestMethod]
        public void ConsoleAppMsgProvider()
        {
            messageProvider = new ConsoleAppMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }


        [TestMethod]
        public void MobileAppMsgProvider()
        {
            messageProvider = new MobileAppMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WebAppMsgProvider()
        {
            messageProvider = new WebAppMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }

        [TestMethod]
        public void WindowsServiceMsgProvider()
        {
            messageProvider = new WindowsServiceMsgProvider();
            message = messageProvider.GetMessage();

            Assert.AreEqual(expectedResult, message);
        }
    }
}

