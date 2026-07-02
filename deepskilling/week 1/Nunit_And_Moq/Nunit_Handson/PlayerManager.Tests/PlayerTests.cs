using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayersManagerLib.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> mock;

        [OneTimeSetUp]
        public void Init()
        {
            mock = new Mock<IPlayerMapper>();
        }

        [Test]
        public void RegisterPlayerTest()
        {
            mock.Setup(x =>
                x.IsPlayerNameExistsInDb(
                    It.IsAny<string>()))
                .Returns(false);

            Player player =
                Player.RegisterNewPlayer(
                    "Virat",
                    mock.Object);

            Assert.That(player.Name,
                Is.EqualTo("Virat"));

            Assert.That(player.Age,
                Is.EqualTo(23));

            Assert.That(player.Country,
                Is.EqualTo("India"));
        }
    }
}