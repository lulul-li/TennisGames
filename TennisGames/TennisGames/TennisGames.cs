using System;
using System.Collections.Generic;

namespace TennisGames
{
    public class TennisGames
    {
        public int FirstPlayerScoreTimes { get; set; }

        public int SecondPlayerScoreTimes { get; set; }

        public string SecondPlayerName { get; set; }

        public string FirstPlayerName { get; set; }

        private Dictionary<int, string> ScoreLookup = new Dictionary<int, string>()
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" }
        };


        public TennisGames(string firstPlayerName, string secondPlayerName)
        {

            FirstPlayerName = firstPlayerName;
            SecondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (DiffScore())
            {
                if (ReadyWin())
                {
                    return IsWin() ? $"{Winer()} Win" : $"{Winer()} Adv";
                }
                return NormalScore();
            }

            return Deuce() ? "Deuce" : $"{ScoreLookup[FirstPlayerScoreTimes]} All";
        }

        private string NormalScore()
        {
            return $"{ScoreLookup[FirstPlayerScoreTimes]} {ScoreLookup[SecondPlayerScoreTimes]}";
        }

        private bool DiffScore()
        {
            return FirstPlayerScoreTimes != SecondPlayerScoreTimes;
        }

        private bool Deuce()
        {
            return FirstPlayerScoreTimes >= 3;
        }

        private bool ReadyWin()
        {
            return FirstPlayerScoreTimes > 3||SecondPlayerScoreTimes>3;
        }

        private bool IsWin()
        {
            return Math.Abs(FirstPlayerScoreTimes - SecondPlayerScoreTimes) > 1;
        }

        private string Winer()
        {
            return FirstPlayerScoreTimes > SecondPlayerScoreTimes ? FirstPlayerName : SecondPlayerName;
        }


        public void FirstPlayerScore()
        {
            FirstPlayerScoreTimes++;
        }

        public void SecondPlayerScore()
        {
            SecondPlayerScoreTimes++;
        }
    }
}