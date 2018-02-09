using NUnit.Framework;

namespace TennisGamesTest
{
    [TestFixture]
    public class UnitTest1
    {
        private TennisGames.TennisGames _tennisGames;

        [SetUp]
        public void SetUp()
        {
            _tennisGames = new TennisGames.TennisGames("Lulu", "Ruru"); ;
        }

        [Test]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [Test]
        public void Love_Fifteen()
        {
            SecondPlayerScoreTimes(_tennisGames, 1);
            ScoreShouldBe("Love Fifteen");
        }

        [Test]
        public void Thirty_Love()
        {
            FirstPlayerScoreTimes(_tennisGames, 2);
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void Forty_Love()
        {
            FirstPlayerScoreTimes(_tennisGames, 3);
            ScoreShouldBe("Forty Love");
        }

        [Test]
        public void Fifteen_Love()
        {
            FirstPlayerScoreTimes(_tennisGames, 1);
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void Fifteen_All()
        {
            FirstPlayerScoreTimes(_tennisGames, 1);
            SecondPlayerScoreTimes(_tennisGames, 1);
            ScoreShouldBe("Fifteen All");
        }

        [Test]
        public void Thirty_All()
        {
            FirstPlayerScoreTimes(_tennisGames, 2);
            SecondPlayerScoreTimes(_tennisGames, 2);
            ScoreShouldBe("Thirty All");
        }

        [Test]
        public void Deuce_when_3_3()
        {
            FirstPlayerScoreTimes(_tennisGames, 3);
            SecondPlayerScoreTimes(_tennisGames, 3);
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void Deuce_when_4_4()
        {
            FirstPlayerScoreTimes(_tennisGames, 4);
            SecondPlayerScoreTimes(_tennisGames, 4);
            ScoreShouldBe("Deuce");
        }

        [Test]
        public void FirstPlayer_Advantage()
        {
            FirstPlayerScoreTimes(_tennisGames, 4);
            SecondPlayerScoreTimes(_tennisGames, 3);
            ScoreShouldBe("Lulu Adv");
        }

        [Test]
        public void SecondPlayer_Advantage()
        {
            FirstPlayerScoreTimes(_tennisGames, 3);
            SecondPlayerScoreTimes(_tennisGames, 4);
            ScoreShouldBe("Ruru Adv");
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

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennisGames.Score());
        }
    }
}