using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ConsoleApplication2;

namespace UnitTestProject1
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void AddWithAllPositive()
        {
            //Assemble
            var a = 5;
            var b = 2;
            var business = new Mock<IBusiness>();
            business.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(4);
            var c = new Controller(business.Object);
            //
            var result = c.Add(a, b);
            //Assert
            Assert.AreEqual(5, result);
        }
    }
}
