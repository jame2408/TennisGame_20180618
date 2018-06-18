using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame_20180618
{
    [TestClass]
    public class TestTennisGame
    {
        private readonly TennisGame _tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}