using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PlayersManagerLib;
using NUnit.Compatibility;


namespace PlayerManager.Tests
{
    [TestFixture]
    public class Class1
    {
        Mock<IPlayerMapper> mock;
        [OneTimeSetUp]
        public void init()
        {
            mock = new Mock<IPlayerMapper>();
        }
        [Test]
        [TestCase("")]
        public void EmptyName(string name)
        {
            Player player;
            Assert.That(() => player = Player.RegisterNewPlayer(name, mock.Object), Throws.TypeOf<ArgumentException>());
            
        }
        [Test]
        [TestCase("Sudharsan")]
        public void AlreadyInDb(string name)
        {
            mock.Setup(x => x.IsPlayerNameExistsInDb(name)).Returns(true);
            Player player; 
            Assert.That(() => player = Player.RegisterNewPlayer(name, mock.Object), Throws.TypeOf<ArgumentException>());
        }
    
    [Test]
    [TestCase("Sudharsan","India")]

    public void NotInDb(string name,string country)
        {
            mock.Setup(x => x.IsPlayerNameExistsInDb(name)).Returns(false);
            Player player = Player.RegisterNewPlayer(name, mock.Object);
            Assert.AreEqual(name, player.Name);
            Assert.AreEqual(20, player.Age);

            Assert.AreEqual(country, player.Country);
            Assert.AreEqual(20, player.NoOfMatches);

        }
    }
}
