namespace TennisGame_20180618
{
    public class TennisGame
    {
        private int _firstPlayerScore = 0;

        public string Score()
        {
            if (_firstPlayerScore == 2)
            {
                return "Thirty Love";
            }
            return _firstPlayerScore == 1 ? "Fifteen Love" : "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}