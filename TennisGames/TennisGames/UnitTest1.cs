using NUnit.Framework;

namespace TennisGamesTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Love_All()
        {
            var tennisGames = new TennisGames.TennisGames();
            ScoreShouldBe("Love All", tennisGames.Score());
        }

        [Test]
        public void Love_Fifteen()
        {
            var tennisGames = new TennisGames.TennisGames();
            SecondPlayerScoreTimes(tennisGames, 1);
            ScoreShouldBe("Love Fifteen", tennisGames.Score());
        }

        [Test]
        public void Thirty_Love()
        {
            var tennisGames = new TennisGames.TennisGames();
            FirstPlayerScoreTimes(tennisGames, 2);
            ScoreShouldBe("Thirty Love", tennisGames.Score());
        }

        [Test]
        public void Forty_Love()
        {
            var tennisGames = new TennisGames.TennisGames();
            FirstPlayerScoreTimes(tennisGames, 3);
            ScoreShouldBe("Forty Love", tennisGames.Score());
        }

        [Test]
        public void Fifteen_Love()
        {
            var tennisGames = new TennisGames.TennisGames();

            FirstPlayerScoreTimes(tennisGames, 1);
            ScoreShouldBe("Fifteen Love", tennisGames.Score());
        }

        [Test]
        public void Fifteen_All()
        {
            var tennisGames = new TennisGames.TennisGames();

            FirstPlayerScoreTimes(tennisGames, 1);
            SecondPlayerScoreTimes(tennisGames, 1);
            ScoreShouldBe("Fifteen All", tennisGames.Score());
        }

        [Test]
        public void Thirty_All()
        {
            var tennisGames = new TennisGames.TennisGames();

            FirstPlayerScoreTimes(tennisGames, 2);
            SecondPlayerScoreTimes(tennisGames, 2);
            ScoreShouldBe("Thirty All", tennisGames.Score());
        }

        private static void FirstPlayerScoreTimes(TennisGames.TennisGames tennisGames, int times)
        {
            for (var i = 0; i < times; i++)
            {
                tennisGames.FirstPlayerScore();
            }
        }

        private void SecondPlayerScoreTimes(TennisGames.TennisGames tennisGames, int times)
        {
            for (int j = 0; j < times; j++)
            {
                tennisGames.SecondPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}