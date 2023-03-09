using HangMan.Interfaces.Models;

namespace HangMan.Models
{
    public class WordProgress : IWordProgress
    {
        public string State { get; set; }

        private readonly ITargetWord _targetWord;

        public WordProgress(ITargetWord targetWord)
        {
            _targetWord= targetWord;
            State = targetWord.Dashes ?? string.Empty;
        }

        public void Update(char letter) 
        {
            if (_targetWord?.Value == null)
            {
                return;
            }

            var targetAsCharArray = _targetWord.Value.ToCharArray();
            var stateAsCharArray = State.ToCharArray();

            for (int index = 0; index < stateAsCharArray?.Length; index++) 
            {
                if (Match(letter, targetAsCharArray[index])) 
                {
                    stateAsCharArray[index] = letter.ToString().ToUpperInvariant().ToCharArray()[0];
                }
            }

            if (stateAsCharArray?.ToString() != null && State != null)
            {
                State = BuildStringFromCharArray(stateAsCharArray);
            }

        }

        public bool Guessed()
        {
            return State == _targetWord.Value?.ToUpperInvariant();
        }

        private static bool Match(char letter, char targetWordLetter)
        {
            return letter.ToString().ToUpperInvariant() == targetWordLetter.ToString().ToUpperInvariant();
        }

        private string BuildStringFromCharArray(char[] charArray)
        {
            var stringToBuild = string.Empty;

            foreach (char c in charArray) 
            {
                stringToBuild += c;
            }

            return stringToBuild;
        }
    }
}
