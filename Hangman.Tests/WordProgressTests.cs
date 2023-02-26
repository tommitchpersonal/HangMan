using FluentAssertions;
using HangMan.Interfaces.Models;
using Xunit;
using NSubstitute;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using HangMan.Models;

namespace Hangman.Tests
{
    public class WordProgressTests
    {
        [Fact]
        public void WhenInitialisedJustSetToDashes()
        {
            var testTargetWord = CreateTestTargetWord();

            var sut = new WordProgress(testTargetWord);

            sut.State.Returns(testTargetWord.Dashes);
        }

        [Fact]
        public void StateFillsInCorrectLetter()
        {
            var testTargetWord = CreateTestTargetWord();

            var sut = new WordProgress(testTargetWord);
            sut.Update('E');

            sut.State.Should().Be("_E__");
        }

        [Fact]
        public void MultipleLettersCanBeReplaced()
        {
            var testTargetWord = CreateTestTargetWord();

            var sut = new WordProgress(testTargetWord);
            sut.Update('T');

            sut.State.Should().Be("T__T");
        }

        [Fact]
        public void HandlesLowerCase()
        {
            var testTargetWord = CreateTestTargetWord();

            var sut = new WordProgress(testTargetWord);
            sut.Update('e');

            sut.State.Should().Be("_E__");
        }

        private static ITargetWord CreateTestTargetWord()
        {
            var testTargetWord = Substitute.For<ITargetWord>();

            var testDashes = "____";
            testTargetWord.Dashes.Returns(testDashes);

            var testWord = "TEST";
            testTargetWord.Value.Returns(testWord);

            return testTargetWord;
        }
    }
}
