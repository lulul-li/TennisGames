using System;
using NUnit.Framework;

namespace TennisGamesTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Love_All()
        {
            var tennisGames = new TennisGames();
            var score = tennisGames.Score();
            Assert.AreEqual("Love_All",score);
        }
        
    }

    public class TennisGames
    {
        public string Score()
        {
            return "Love_All";
        }
    }
}
