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
    }
}