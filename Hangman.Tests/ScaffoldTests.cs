using FluentAssertions;
using HangMan.Models;
using HangMan.Models.ScaffoldComponents;
using Xunit;
using NSubstitute;
using HangMan.Interfaces.Builders;

namespace Hangman.Tests
{
    public class ScaffoldTests
    {
        private IScaffoldComponentArranger _sScaffoldBuilder = Substitute.For<IScaffoldComponentArranger>();

        [Fact]
        public void WhenInitialisedStateIsEmptyList()
        {
            var scaffold = new Scaffold(_sScaffoldBuilder);
            scaffold.State.Count.Should().Be(0);
        }

        [Fact]
        public void FirstComponentAddedToScaffoldIsBase()
        {
            RunTest(0, typeof(ScaffoldBase));
        }

        [Fact]
        public void SecondComponentAddedToScaffoldIsPole()
        {
            RunTest(1, typeof(ScaffoldPole));
        }

        [Fact]
        public void ThirdComponentAddedToScaffoldIsArm()
        {
            RunTest(2, typeof(ScaffoldArm));
        }

        [Fact]
        public void FourthComponentAddedToScaffoldIsRope()
        {
            RunTest(3, typeof(ScaffoldRope));
        }

        [Fact]
        public void FifthComponentAddedToScaffoldIsHead()
        {
            RunTest(4, typeof(ScaffoldHead));
        }

        [Fact]
        public void SixthComponentAddedToScaffoldIsBody()
        {
            RunTest(5, typeof(ScaffoldBody));
        }

        [Fact]
        public void SeventhComponentAddedToScaffoldIsPersonArm()
        {
            RunTest(6, typeof(ScaffoldPersonArm));
        }

        [Fact]
        public void EigthComponentAddedToScaffoldIsPersonArm()
        {
            RunTest(7, typeof(ScaffoldPersonArm));
        }

        [Fact]
        public void NinthComponentAddedToScaffoldIsLeftLeg()
        {
            RunTest(8, typeof(ScaffoldLeftLeg));
        }

        [Fact]
        public void TenthComponentAddedToScaffoldIsRightLeg()
        {
            RunTest(9, typeof(ScaffoldRightLeg));
        }

        private void RunTest(int componentNumber, Type expectedType)
        {
            var scaffold = new Scaffold(_sScaffoldBuilder);
            
            for (var i = 0; i <= componentNumber; i++)
            {
                scaffold.AddComponent();
            }

            scaffold.State.Count.Should().Be(componentNumber + 1);
            scaffold.State.Last().GetType().Should().Be(expectedType);
        }
    }
}
