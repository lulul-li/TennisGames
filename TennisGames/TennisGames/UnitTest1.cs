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
            ScoreShouldBe("Love_All", tennisGames.Score());
        }

        [Test]
        public void Fifteen_Love()
        {
            var tennisGames = new TennisGames();
            tennisGames.FirstPlayerScore();
            ScoreShouldBe("Fifteen_Love", tennisGames.Score());
        }

        private void ScoreShouldBe(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }

    public class TennisGames
    {
        public string Score()
        {
            if (FirstPlayerScoreTimes == 1)
            {
                return "Fifteen_Love";
            }

            return "Love_All";
        }

        public void FirstPlayerScore()
        {
            FirstPlayerScoreTimes++;
        }

        public int FirstPlayerScoreTimes { get; set; }
    }
}