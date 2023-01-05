using HangMan.Interfaces.Models;

namespace HangMan.Models
{
    public class TargetWord : ITargetWord
    {
        public string? Value {get; set;}
        public string? Dashes {get; set;}
        public void SetNewWord(string? wordToSet)
        {
            if (wordToSet == null)
            {
                SetEmpty();
                return;
            }

            if (!OnlyContainsLettersAndSpaces(wordToSet))
            {
                SetEmpty();
                return;
            }

            Value = wordToSet;

            Dashes = BuildDashesFromWord(wordToSet);
        }

        private string BuildDashesFromWord(string word)
        {
            var dashes = string.Empty;
            
            var wordToSetAsCharArray = word.ToCharArray();

            foreach (var character in wordToSetAsCharArray)
            {
                if (character == " ".ToCharArray()[0])
                {
                    dashes += " ";
                }
                else 
                {
                    dashes += "-";
                }
            }

            return dashes;
        }

        private bool OnlyContainsLettersAndSpaces(string word)
        {
            return word.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c));
        }

        private void SetEmpty()
        {
            Value = string.Empty;
            Dashes = string.Empty;
        }
    }
}