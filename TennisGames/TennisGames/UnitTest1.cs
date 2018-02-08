﻿using NUnit.Framework;
using System.Collections.Generic;

namespace TennisGamesTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Love_All()
        {
            var tennisGames = new TennisGames();
            ScoreShouldBe("Love All", tennisGames.Score());
        }

        [Test]
        public void Fifteen_Love()
        {
            var tennisGames = new TennisGames();
            tennisGames.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love", tennisGames.Score());
        }

        [Test]
        public void Thirty_Love()
        {
            var tennisGames = new TennisGames();
            tennisGames.FirstPlayerScore();
            tennisGames.FirstPlayerScore();
            ScoreShouldBe("Thirty Love", tennisGames.Score());
        }

        private void ScoreShouldBe(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }

    public class TennisGames
    {
        private Dictionary<int, string> ScoreLookup = new Dictionary<int, string>()
        {
            {0,"Love" },
            {1,"Fifteen" },
            {2,"Thirty" }
        };

        public string Score()
        {
            if (FirstPlayerScoreTimes > 0)
            {
                return $"{ScoreLookup[FirstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            FirstPlayerScoreTimes++;
        }

        public int FirstPlayerScoreTimes { get; set; }
    }
}