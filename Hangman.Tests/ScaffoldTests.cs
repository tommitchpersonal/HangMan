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
            RunTest(0, typeof(ScaffoldWithBase));
        }

        [Fact]
        public void SecondComponentAddedToScaffoldIsPole()
        {
            RunTest(1, typeof(ScaffoldWithPole));
        }

        [Fact]
        public void ThirdComponentAddedToScaffoldIsArm()
        {
            RunTest(2, typeof(ScaffoldWithArm));
        }

        [Fact]
        public void FourthComponentAddedToScaffoldIsRope()
        {
            RunTest(3, typeof(ScaffoldWithRope));
        }

        [Fact]
        public void FifthComponentAddedToScaffoldIsHead()
        {
            RunTest(4, typeof(ScaffoldWithHead));
        }

        [Fact]
        public void SixthComponentAddedToScaffoldIsBody()
        {
            RunTest(5, typeof(ScaffoldWithBody));
        }

        [Fact]
        public void SeventhComponentAddedToScaffoldIsPersonArm()
        {
            RunTest(6, typeof(ScaffoldWithLeftArm));
        }

        [Fact]
        public void EigthComponentAddedToScaffoldIsPersonArm()
        {
            RunTest(7, typeof(ScaffoldWithLeftArm));
        }

        [Fact]
        public void NinthComponentAddedToScaffoldIsLeftLeg()
        {
            RunTest(8, typeof(ScaffoldLeftLeg));
        }

        [Fact]
        public void TenthComponentAddedToScaffoldIsRightLeg()
        {
            RunTest(9, typeof(ScaffoldWithRightLeg));
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
