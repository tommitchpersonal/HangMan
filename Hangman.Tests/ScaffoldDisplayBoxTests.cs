using FluentAssertions;
using HangMan.Models.ScaffoldComponents;
using Xunit;

namespace Hangman.Tests
{

    public class ScaffoldDisplayBoxTests
    {
        private readonly ScaffoldDisplayBox _sut = new();

        [Fact]
        public void FirstElementReturnedIsEmptyScaffold()
        {
            var result = _sut.Select(0);
            result?.GetType().Should().Be(typeof(EmptyScaffold));
        }

        [Fact]
        public void SecondElementReturnedIsScaffoldWithBase()
        {
            var result = _sut.Select(1);
            result?.GetType().Should().Be(typeof(ScaffoldWithBase));
        }

        [Fact]
        public void ThirdElementReturnedIsScaffoldWithPole()
        {
            var result = _sut.Select(2);
            result?.GetType().Should().Be(typeof(ScaffoldWithPole));
        }

        [Fact]
        public void FourthElementReturnedIsScfaffoldWithArm()
        {
            var result = _sut.Select(3);
            result?.GetType().Should().Be(typeof(ScaffoldWithArm));
        }

        [Fact]
        public void FifthElementReturnedIsScaffoldWithRope()
        {
            var result = _sut.Select(4);
            result?.GetType().Should().Be(typeof(ScaffoldWithRope));
        }

        [Fact]
        public void SixthElementReturnedIsScaffoldWithHead()
        {
            var result = _sut.Select(5);
            result?.GetType().Should().Be(typeof(ScaffoldWithHead));
        }

        [Fact]
        public void SeventhElementReturnedIsScaffoldWithBody()
        {
            var result = _sut.Select(6);
            result?.GetType().Should().Be(typeof(ScaffoldWithBody));
        }

        [Fact]
        public void EightElementReturnedIsScaffoldWithLeftArm()
        {
            var result = _sut.Select(7);
            result?.GetType().Should().Be(typeof(ScaffoldWithLeftArm));
        }

        [Fact]
        public void NinthElementReturnedIsScaffoldWithRightArm()
        {
            var result = _sut.Select(8);
            result.GetType().Should().Be(typeof(ScaffoldWithRightArm));
        }

        [Fact]
        public void TenthElementReturnedIsScaffoldWithLeftLeg()
        {
            var result = _sut.Select(9);
            result?.GetType().Should().Be(typeof(ScaffoldWithLeftLeg));
        }

        [Fact]
        public void EleventhElementReturnedIsScaffoldWithRightLeg()
        {
            var result = _sut.Select(10);
            result?.GetType().Should().Be(typeof(ScaffoldWithRightLeg));
        }

        [Fact]
        public void ReturnsNullIfPassedIndexLessThanZero()
        {
            var result = _sut.Select(-1);
            result.Should().BeNull();
        }

        [Fact] 
        public void ReturnsNullIfPassedIndexGreaterThanTen()
        {
            var result = _sut.Select(11);
            result.Should().BeNull();
        }

    }
}
