using System.Collections.Generic;

namespace TennisGame_20180618
{
    public class TennisGame
    {
        private int _firstPlayerScore = 0;

        private int _secondPlayerScore = 0;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Fourty" }
        };

        public string Score()
        {
            if (_firstPlayerScore == _secondPlayerScore)
            {
                return _scoreLookup[_firstPlayerScore] + " All";
            }

            return NormalScore();
        }

        private string NormalScore()
        {
            return _scoreLookup[_firstPlayerScore] + " " + _scoreLookup[_secondPlayerScore];
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}