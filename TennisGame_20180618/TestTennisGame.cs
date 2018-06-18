using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame_20180618
{
    [TestClass]
    public class TestTennisGame
    {
        [TestMethod]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            Assert.AreEqual("Love All", tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            var tennisGame = new TennisGame();
            tennisGame.FirstPlayerScore();
            Assert.AreEqual("Fifteen Love", tennisGame.Score());
        }
    }
}