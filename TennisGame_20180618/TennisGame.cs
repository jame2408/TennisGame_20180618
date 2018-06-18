using System;
using System.Collections.Generic;

namespace TennisGame_20180618
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;
        private readonly string _secondPlayerName;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

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
            return IsScoreDifferent()
                ? (IsReadyForWin() ? AdvOrWin() : NormalScore())
                : (IsDeuce() ? Deuce() : SameScore());
        }

        private string AdvOrWin()
        {
            return IsAdv() ? ReadyForWinName() + " Adv" : ReadyForWinName() + " Win";
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1;
        }

        private string ReadyForWinName()
        {
            return _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
        }

        private bool IsReadyForWin()
        {
            return _firstPlayerScore > 3 || _secondPlayerScore > 3;
        }

        private bool IsScoreDifferent()
        {
            return _firstPlayerScore != _secondPlayerScore;
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3 && _secondPlayerScore >= 3;
        }

        private string SameScore()
        {
            return _scoreLookup[_firstPlayerScore] + " All";
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