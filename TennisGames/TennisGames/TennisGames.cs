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
            if (FirstPlayerScoreTimes != SecondPlayerScoreTimes)
            {
                if (FirstPlayerScoreTimes > 3||SecondPlayerScoreTimes>3)
                {
                    if (Math.Abs(FirstPlayerScoreTimes - SecondPlayerScoreTimes) > 1)
                    {
                        return $"{Winer()} Win";
                    }
                    return $"{Winer()} Adv";
                }
                return $"{ScoreLookup[FirstPlayerScoreTimes]} {ScoreLookup[SecondPlayerScoreTimes]}";
            }
            if (FirstPlayerScoreTimes >= 3)
            {
                return "Deuce";
            }

            return $"{ScoreLookup[FirstPlayerScoreTimes]} All";
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