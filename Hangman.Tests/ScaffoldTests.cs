using FluentAssertions;
using HangMan.Models;
using Xunit;
using NSubstitute;
using HangMan.Interfaces.Models;

namespace Hangman.Tests
{
    public class ScaffoldTests
    {
        private IScaffoldDisplayBox _displayBox = Substitute.For<IScaffoldDisplayBox>();

        [Fact]
        public void WhenInitialisedScaffoldDisplayIsEmptyString()
        {
            var scaffold = new Scaffold(_displayBox);
            scaffold.Display.Should().NotBeNull();
            scaffold.Display?.Value.Should().Be(string.Empty);
        }

        [Fact]
        public void WhenWrongGuessIsAddedDisplayStateIsIncremented()
        {
            var testDisplay = new TestDisplay();
            _displayBox.Select(Arg.Is<int>(1)).Returns(testDisplay);

            var scaffold = new Scaffold(_displayBox);
            scaffold.AddWrongGuess();

            _displayBox.Received(1).Select(1);

            scaffold.Display?.Value.Should().Be(testDisplay.Value);
        }
    }
    
    public class TestDisplay : IScaffoldDisplay
    {
        public string Value { get; } = "This is a test";
    }
}
