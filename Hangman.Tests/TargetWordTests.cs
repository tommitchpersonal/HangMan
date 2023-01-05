using Xunit;
using HangMan.Models;
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
        sut.SetNewWord(testWord);

        // Assert
        sut.Dashes?.Length.Should().Be(testWord.Length);
        sut.Dashes.Should().Be("----");
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
        sut.SetNewWord(testWord);

        // Assert
        sut.Value.Should().Be(testWord);
        sut.Dashes.Should().Be("- ----");
    }

    [Fact]
    public void ValueAndDashesAreEmptyStringsForEmptyString()
    {
        // Arrange
        var testWord = string.Empty;

        // Execute
        var sut = new TargetWord();
        sut.SetNewWord(testWord);

        // Assert
        sut.Value.Should().Be(testWord);
        sut.Dashes.Should().Be(string.Empty);
    }

    [Fact]
    public void ValueAndDashesAreEmptyStringForNullInput()
    {
        // Arrange
        string? testWord = null;

        // Execute
        var sut = new TargetWord();
        sut.SetNewWord(testWord);

        // Assert
        sut.Value.Should().Be(string.Empty);
        sut.Dashes.Should().Be(string.Empty);
    }

    [Fact]
    public void DoesNotAcceptNumbersInWord()
    {
        // Arrange
        string? testWord = "T3st W0rd";

        // Execute
        var sut = new TargetWord();
        sut.SetNewWord(testWord);

        // Assert
        sut.Value.Should().Be(string.Empty);
        sut.Dashes.Should().Be(string.Empty);
    }

    [Fact]
    public void DoesNotAcceptSpecialCharactersInWord()
    {
        // Arrange
        string? testWord = "t£st w@rd";

        // Execute
        var sut  = new TargetWord();
        sut.SetNewWord(testWord);

        // Assert 
        sut.Value.Should().Be(string.Empty);
        sut.Dashes.Should().Be(string.Empty);
    }
}