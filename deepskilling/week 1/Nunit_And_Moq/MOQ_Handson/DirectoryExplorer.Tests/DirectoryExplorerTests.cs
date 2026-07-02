using MagicFilesLib;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace MagicFilesLib.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> mock;

        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            mock = new Mock<IDirectoryExplorer>();
        }

        [Test]
        public void GetFilesTest()
        {
            var files = new List<string>
            {
                _file1,
                _file2
            };

            mock.Setup(x =>
                x.GetFiles(It.IsAny<string>()))
                .Returns(files);

            var result =
                mock.Object.GetFiles("C:\\");

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.Contains(_file1), Is.True);
        }
    }
}