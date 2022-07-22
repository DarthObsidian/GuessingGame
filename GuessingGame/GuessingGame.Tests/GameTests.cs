namespace GuessingGame.Tests
{
    public class GameTests
    {
        Game game;

        [SetUp]
        public void Setup()
        {
            game = new();
            game.CurrentNum = 500;
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
            game.CheckGuess(5);
            game.CheckGuess(5);
            game.CheckGuess(5);
            Assert.That(game.TotalGuesses, Is.EqualTo(1));
        }

        [Test]
        public void NonConsecutiveDuplicateGuessesAreCounted()
        {
            game.CheckGuess(5);
            game.CheckGuess(500);
            game.CheckGuess(5);
            Assert.That(game.TotalGuesses, Is.EqualTo(3));
        }

        [Test]
        public void SetupResetsGameData()
        {
            game.CurrentNum = 50;
            game.TotalGuesses = 500;
            game.Setup();
            Assert.Multiple(() =>
            {
                Assert.That(game.CurrentNum, Is.Not.EqualTo(50));
                Assert.That(game.TotalGuesses, Is.EqualTo(0));
            });
        }

        [Test]
        public void StringInputIsInvalid()
        {
            bool result = game.ValidateInput("absec");
            Assert.That(result, Is.False);
        }

        [Test]
        public void NonIntInputIsInvalid()
        {
            bool result = game.ValidateInput("16.5");
            Assert.That(result, Is.False);
        }
    }
}