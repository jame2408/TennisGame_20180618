using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGame_20180618
{
    [TestClass]
    public class TestTennisGame
    {
        private readonly TennisGame _tennisGame = new TennisGame("Joey", "James");

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

        [TestMethod]
        public void Love_Thirty()
        {
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [TestMethod]
        public void Love_Fourty()
        {
            SecondPlayerScoreTimes(3);
            ScoreShouldBe("Love Fourty");
        }

        [TestMethod]
        public void Fifteen_All()
        {
            FirstPlayerScoreTimes(1);
            SecondPlayerScoreTimes(1);
            ScoreShouldBe("Fifteen All");
        }

        [TestMethod]
        public void Thirty_All()
        {
            FirstPlayerScoreTimes(2);
            SecondPlayerScoreTimes(2);
            ScoreShouldBe("Thirty All");
        }

        [TestMethod]
        public void Deuce_3_3()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(3);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void Deuce_4_4()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(4);
            ScoreShouldBe("Deuce");
        }

        [TestMethod]
        public void FirstPlayer_Adv_When_4_3()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(3);
            ScoreShouldBe("Joey Adv");
        }

        [TestMethod]
        public void SecondPlayer_Adv_When_3_4()
        {
            FirstPlayerScoreTimes(3);
            SecondPlayerScoreTimes(4);
            ScoreShouldBe("James Adv");
        }

        [TestMethod]
        public void FirstPlayer_Win_When_4_0()
        {
            FirstPlayerScoreTimes(4);
            ScoreShouldBe("Joey Win");
        }

        [TestMethod]
        public void SecondPlayer_Win_When_4_6()
        {
            FirstPlayerScoreTimes(4);
            SecondPlayerScoreTimes(6);
            ScoreShouldBe("James Win");
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