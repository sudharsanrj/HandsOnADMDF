using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using Moq;
using NUnit.Framework;
using MagicFilesLib;
namespace DirectoryExplorerTests
{
    [TestFixture]
    public class Class1
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        Mock<IDirectoryExplorer> mock;
        [OneTimeSetUp]

        public void Setup()
        {
            mock = new Mock<IDirectoryExplorer>();
        }

        [TestCase("/Home/607302")]

        public void TestorClass(string path)
        {
            List<string> files = new List<string>()
            {
                _file1,
            _file2
            };



            mock.Setup(p => p.GetFiles(path)).Returns(files);
            var result = mock.Object.GetFiles(path);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Contains(_file1));

        }

    }
    
    
}
