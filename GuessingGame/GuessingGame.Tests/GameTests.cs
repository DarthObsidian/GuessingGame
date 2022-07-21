namespace GuessingGame.Tests
{
    public class GameTests
    {
        Game game;

        [SetUp]
        public void Setup()
        {
            game = new();
            game.currentNum = 500;
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
            int result = game.CheckGuess(600);
            Assert.That(result, Is.GreaterThan(0));
        }

        [Test]
        public void LowGuessIsAnsweredAsSuch()
        {
            int result = game.CheckGuess(50);
            Assert.That(result, Is.LessThan(0));
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

        [Test]
        public void StringInputIsInvalid()
        {
            Assert.Fail();
        }

        public void NonIntInputIsInvalid()
        {
            Assert.Fail();
        }
    }
}