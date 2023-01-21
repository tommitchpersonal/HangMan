using FluentAssertions;
using HangMan.Models;
using Xunit;


namespace Hangman.Tests
{
    public class ScaffoldTests
    {
        [Fact]
        public void WhenInitialisedStateIsEmptyString()
        {
            var scaffold = new Scaffold();
            scaffold.State.Should().Be(string.Empty);
        }

        [Fact]
        public void OnFirstIncorrectAnswerStateIsScaffoldBase()
        {

        }
    }
}
