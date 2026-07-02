using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerCommLib.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender> mock;

        [OneTimeSetUp]
        public void Init()
        {
            mock = new Mock<IMailSender>();
        }

        [Test]
        public void SendMailToCustomerTest()
        {
            mock.Setup(x =>
                x.SendMail(
                    It.IsAny<string>(),
                    It.IsAny<string>()))
                .Returns(true);

            var customer = new CustomerComm(mock.Object);

            bool result = customer.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
}