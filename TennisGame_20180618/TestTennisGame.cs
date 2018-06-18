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
            FirstPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            FirstPlayerScoreTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Fourty_Love()
        {
            FirstPlayerScoreTimes(3);
            ScoreShouldBe("Fourty Love");
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            SecondPlayerScoreTimes(1);
            ScoreShouldBe("Love Fifteen");
        }

        private void SecondPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScore();
            }
        }

        private void FirstPlayerScoreTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGame.Score());
        }
    }
}