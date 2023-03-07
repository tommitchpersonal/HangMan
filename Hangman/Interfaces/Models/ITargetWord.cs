namespace HangMan.Interfaces.Models
{
    public interface ITargetWord
    {
        public string? Value {get; set;}
        public string? Dashes {get; set;}
        public void SetNewWord(string? wordToSet);
        public bool IsValid();
    }
}