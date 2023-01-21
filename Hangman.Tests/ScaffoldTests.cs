using FluentAssertions;
using HangMan.Models;
using HangMan.Models.ScaffoldComponents;
using Xunit;


namespace Hangman.Tests
{
    public class ScaffoldTests
    {
        [Fact]
        public void WhenInitialisedStateIsEmptyList()
        {
            var scaffold = new Scaffold();
            scaffold.State.Count.Should().Be(0);
        }

        [Fact]
        public void OnFirstIncorrectAnswerStateIsScaffoldBase()
        {
            var scaffold = new Scaffold();
            scaffold.AddComponent();
            scaffold.State.Count.Should().Be(1);

            var scaffoldBase = new ScaffoldBase();
            scaffold.State[0].Value.Should().Be(scaffoldBase.Value);
        }
    }
}
