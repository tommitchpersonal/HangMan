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
            var testScaffoldBase = new ScaffoldBase();
            var testScaffoldPole = new ScaffoldPole();

            var testState = new List<IScaffoldComponent>()
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
            var testScaffoldBase = new ScaffoldBase();
            var testScaffoldPole = new ScaffoldPole();
            var testScaffoldArm = new ScaffoldArm();

            var testState = new List<IScaffoldComponent>()
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
