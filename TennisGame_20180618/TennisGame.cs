using System.Collections.Generic;

namespace TennisGame_20180618
{
    public class TennisGame
    {
        private int _firstPlayerScore = 0;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Fourty" }
        };

        public string Score()
        {
            return _firstPlayerScore > 0 ?
                _scoreLookup[_firstPlayerScore] + " Love" :
                "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}