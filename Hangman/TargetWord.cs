// Tests

// WHEN "setter" inputs a word
// The target word is saved
// The correct number of dashes are returned
// The inputted word is NOT visible anywhere
namespace HangMan
{
    public class TargetWord
    {
        public string? Value {get; set;}
        public string SetNewWord(string wordToSet)
        {
            Value = wordToSet;

            var dashes = string.Empty;
            
            var wordToSetAsCharArray = wordToSet.ToCharArray();

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
    }
}