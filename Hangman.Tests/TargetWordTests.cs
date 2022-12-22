using Xunit;
using HangMan;
using FluentAssertions;

public class TargetWordTests
{
    [Fact]
    public void NumberOfUnderScoresOfWordLengthReturnedWhenWordSet()
    {
        // Arrange
        var testWord = "test";

        // Execute
        var sut = new TargetWord();
        var dashes = sut.SetNewWord(testWord);

        // Assert
        dashes.Length.Should().Be(testWord.Length);
        dashes.Should().Be("----");
    }

    [Fact]
    public void TargetWordValueIsSetToInputtedWord()
    {
        // Arrange 
        var testWord = "test";

        // Execute
        var sut = new TargetWord();
        sut.SetNewWord(testWord);

        // Assert
        sut.Value.Should().Be(testWord);
    }

    [Fact]
    public void SpaceInsteadOfDashUsedForInputtedSpaces()
    {
        // Arrange
        var testWord = "a word";

        // Execute
        var sut = new TargetWord();
        var dashes = sut.SetNewWord(testWord);

        // Assert
        dashes.Should().Be("- ----");
    }
}