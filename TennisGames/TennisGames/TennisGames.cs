using System.Collections.Generic;

namespace TennisGames
{
    public class TennisGames
    {
        public int FirstPlayerScoreTimes { get; set; }

        public int SecondPlayerScoreTimes { get; set; }

        private Dictionary<int, string> ScoreLookup = new Dictionary<int, string>()
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" },
            {3,"Forty" }
        };

        public string Score()
        {
            if (FirstPlayerScoreTimes != SecondPlayerScoreTimes)
            {
                return $"{ScoreLookup[FirstPlayerScoreTimes]} {ScoreLookup[SecondPlayerScoreTimes]}";
            }
            if (FirstPlayerScoreTimes >= 3)
            {
                return "Deuce";
            }

            return $"{ScoreLookup[FirstPlayerScoreTimes]} All";
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