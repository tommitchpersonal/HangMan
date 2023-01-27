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
        public void FirstComponentAddedToScaffoldIsBase()
        {
            RunTest(1, typeof(ScaffoldBase));
        }

        [Fact]
        public void SecondComponentAddedToScaffoldIsPole()
        {
            RunTest(2, typeof(ScaffoldPole));
        }

        [Fact]
        public void ThirdComponentAddedToScaffoldIsArm()
        {
            RunTest(3, typeof(ScaffoldArm));
        }

        [Fact]
        public void FourthComponentAddedToScaffoldIsRope()
        {
            RunTest(4, typeof(ScaffoldRope));
        }

        [Fact]
        public void FifthComponentAddedToScaffoldIsHead()
        {
            RunTest(5, typeof(ScaffoldHead));
        }

        [Fact]
        public void SixthComponentAddedToScaffoldIsBody()
        {
            RunTest(6, typeof(ScaffoldBody));
        }

        [Fact]
        public void SeventhComponentAddedToScaffoldIsPersonArm()
        {
            RunTest(7, typeof(ScaffoldPersonArm));
        }

        [Fact]
        public void EigthComponentAddedToScaffoldIsPersonArm()
        {
            RunTest(8, typeof(ScaffoldPersonArm));
        }

        [Fact]
        public void NinthComponentAddedToScaffoldIsLeftLeg()
        {
            RunTest(9, typeof(ScaffoldLeftLeg));
        }

        [Fact]
        public void TenthComponentAddedToScaffoldIsRightLeg()
        {
            RunTest(10, typeof(ScaffoldRightLeg));
        }

        private void RunTest(int componentNumber, Type expectedType)
        {
            var scaffold = new Scaffold();
            
            for (var i = 0; i < componentNumber; i++)
            {
                scaffold.AddComponent();
            }

            scaffold.State.Count.Should().Be(componentNumber);
            scaffold.State.Last().GetType().Should().Be(expectedType);
        }
    }
}
