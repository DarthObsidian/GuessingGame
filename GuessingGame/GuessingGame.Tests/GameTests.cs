namespace GuessingGame.Tests
{
    public class GameTests
    {
        Game game;

        [SetUp]
        public void Setup()
        {
            game = new();
        }

        [Test]
        public void GeneratedNumberIsInRange()
        {
            int randomNum = game.GetRandomNumber();
            bool result = randomNum <= 9999 && randomNum >= 0;
            Assert.That(result, Is.True);
        }

        [Test]
        public void HighGuessIsAnsweredAsSuch()
        {
            Assert.Fail();
        }

        [Test]
        public void LowGuessIsAnsweredAsSuch()
        {
            Assert.Fail();
        }

        [Test]
        public void ConsecutiveDuplicateGuessesAreNotCounted()
        {
            Assert.Fail();
        }

        [Test]
        public void NonConsecutiveDuplicateGuessesAreCounted()
        {
            Assert.Fail();
        }

        [Test]
        public void CorrectGuessShowsTotalTries()
        {
            Assert.Fail();
        }
    }
}