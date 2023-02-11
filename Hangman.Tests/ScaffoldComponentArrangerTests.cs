using FluentAssertions;
using HangMan.Builders;
using HangMan.Interfaces.Models;
using HangMan.Models.ScaffoldComponents;
using Xunit;


namespace Hangman.Tests
{
    public class ScaffoldComponentArrangerTests
    {

        [Fact]
        public void WhenPassedOnlyScaffoldBaseReturnsScaffoldBaseString()
        {
            var testScaffoldBase = new ScaffoldBase();

            var testState = new List<IScaffoldComponent>()
            {
                testScaffoldBase
            };

            var sut = new ScaffoldComponentArranger();

            var result = sut.ArrangeScaffoldComponents(testState);

            result.Should().Be(testScaffoldBase.Value);
        }

        [Fact]
        public void WhenPassedBaseAndPoleReturnsCorrectString()
        {
            var testScaffoldBase = new ScaffoldBase()
        }
    }
}
