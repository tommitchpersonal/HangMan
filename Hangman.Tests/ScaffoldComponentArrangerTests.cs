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
            var testScaffoldBase = new ScaffoldWithBase();

            var testState = new List<IScaffoldDisplay>()
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
            var testScaffoldBase = new ScaffoldWithBase();
            var testScaffoldPole = new ScaffoldWithPole();

            var testState = new List<IScaffoldDisplay>()
            {
                testScaffoldBase,
                testScaffoldPole
            };

            var sut = new ScaffoldComponentArranger();

            var result = sut.ArrangeScaffoldComponents(testState);

            result.Should().Be(testScaffoldPole.Value + testScaffoldBase.Value);
        }

        [Fact]
        public void WhenPassedArmRetrunsCorrectString()
        {
            var testScaffoldBase = new ScaffoldWithBase();
            var testScaffoldPole = new ScaffoldWithPole();
            var testScaffoldArm = new ScaffoldWithArm();

            var testState = new List<IScaffoldDisplay>()
            {
                testScaffoldBase,
                testScaffoldPole, 
                testScaffoldArm
            };

            var sut = new ScaffoldComponentArranger();

            var result = sut.ArrangeScaffoldComponents(testState);

            result.Should().Be(testScaffoldArm.Value + testScaffoldPole.Value + testScaffoldBase.Value);
        }
    }
}
