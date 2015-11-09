using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BddDemo.Lib;
using Moq;

namespace BddDemo.Tests
{
    [TestClass]
    public class PaymentTest
    {
        [TestMethod]
        public void Should_Accept_SingleCreditCard()
        {
            var vendorMock = new Mock<IVendor>();
            vendorMock.Setup(foo => foo.VerifyCreditCard("1234")).Returns(true);

            var payment = new Payment(vendorMock.Object);
            var result = payment.Accept("1234");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Should_Accept_AnyCreditCard()
        {
            var vendorMock = new Mock<IVendor>();
            vendorMock.Setup(foo => foo.VerifyCreditCard(It.IsAny<string>())).Returns(true);

            var payment = new Payment(vendorMock.Object);
            var result = payment.Accept("1234234s");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Should_Reject_SingleCreditCard()
        {
            var vendorMock = new Mock<IVendor>();
            vendorMock.Setup(foo => foo.VerifyCreditCard("1234")).Returns(true);

            var payment = new Payment(vendorMock.Object);
            var result = payment.Accept("5678");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Should_Accept_FullIntegrationTest()
        {
            IVendor vendor = new VendorXyz();
            var payment = new Payment(vendor);
            var result = payment.Accept("5678");

            Assert.IsTrue(result);
        }



    }
}
