using HangMan.Interfaces;

namespace HangMan
{
    public class Guesses : IGuesses
    {
        public List<char> _incorrectGuesses { get; set; } = new();
        private List<char> _correctGuesses { get; set; } = new();

        public void AddIncorrectGuess(char incorrectGuess)
        {
            if (!GuessIsLetter(incorrectGuess))
            {
                return;
            }

            _incorrectGuesses.Add(ToUpperCase(incorrectGuess));
        }

        public void AddCorrectGuess(char correctGuess)
        {
            if (!GuessIsLetter(correctGuess)) 
            {
                return;
            }

            _correctGuesses.Add(ToUpperCase(correctGuess));
        }

        public string ReturnIncorrectGuessesAsString()
        {
            var result = string.Empty;

            _incorrectGuesses.ForEach(c => result += c.ToString() + " ");

            return result;
        }

        public bool HasGuessBeenMadeAlready(char guess)
        {
            return _incorrectGuesses.Contains(ToUpperCase(guess)) || _correctGuesses.Contains(ToUpperCase(guess)); 
        }

        private static bool GuessIsLetter(char guess)
        {
            var isLetter = char.IsLetter(guess);

            if (!isLetter)
            {
                Console.WriteLine("Invalid Guess: Enter a letter.");
            }

            return isLetter;
        }

        private static char ToUpperCase(char guess)
        {
            return guess.ToString().ToUpperInvariant().ToCharArray()[0];
        }
    }
}
