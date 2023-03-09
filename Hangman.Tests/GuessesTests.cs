using FluentAssertions;
using HangMan;
using Xunit;

namespace Hangman.Tests
{
    public class GuessesTests
    {
        [Fact]
        public void IncorrectGuessAddedToIncorrectGuesses()
        {
            var sut = new Guesses();
            var testChar = 'A';
            sut.AddIncorrectGuess(testChar);

            sut.ReturnIncorrectGuessesAsString().Should().Contain(testChar.ToString());
        }

        [Fact]
        public void CorrectGuessAddedToCorrectGuesses()
        {
            var sut = new Guesses();
            var testChar = 'A';
            sut.AddCorrectGuess(testChar);

            sut.HasGuessBeenMadeAlready(testChar).Should().BeTrue();
            sut.ReturnIncorrectGuessesAsString().Should().NotContain(testChar.ToString());
        }

        [Fact]
        public void SpaceAddedBetweenIncorrectGuesses()
        {
            var sut = new Guesses();
            var firstTestChar = 'A';
            var secondTestChar = 'B';

            sut.AddIncorrectGuess(firstTestChar);
            sut.AddIncorrectGuess(secondTestChar);

            sut.ReturnIncorrectGuessesAsString().Should().Be(firstTestChar.ToString() + " " + secondTestChar.ToString() + " ");
        }

        [Fact]
        public void LowerCaseLettersAreChangedToUppeCase()
        {
            var sut = new Guesses();
            var testChar = 'a';

            sut.AddIncorrectGuess(testChar);

            sut.ReturnIncorrectGuessesAsString().Should().Contain(testChar.ToString().ToUpperInvariant());
        }

        [Fact]
        public void NumbersNotAccpetedAsIncorrectGuess()
        {
            var sut = new Guesses();
            var testChar = '1';

            sut.AddIncorrectGuess(testChar);

            sut.HasGuessBeenMadeAlready(testChar).Should().BeFalse();
        }

        [Fact]
        public void NumbersNotAccpetedAsCorrectGuess()
        {
            var sut = new Guesses();
            var testChar = '1';

            sut.AddCorrectGuess(testChar);

            sut.HasGuessBeenMadeAlready(testChar).Should().BeFalse();
        }

        [Fact]
        public void SpecialCharctersNotAccpetedAsCorrectGuess()
        {
            var sut = new Guesses();
            var testChar = '!';

            sut.AddCorrectGuess(testChar);

            sut.HasGuessBeenMadeAlready(testChar).Should().BeFalse();
        }

        [Fact]
        public void SpecialCharctersNotAccpetedAsIncorrectGuess()
        {
            var sut = new Guesses();
            var testChar = '!';

            sut.AddIncorrectGuess(testChar);

            sut.HasGuessBeenMadeAlready(testChar).Should().BeFalse();
        }
    }
}
