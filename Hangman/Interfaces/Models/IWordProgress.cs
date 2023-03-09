namespace HangMan.Interfaces.Models
{
    public interface IWordProgress
    {
        public string State { get; set; }
        public void Update(char letter);
        public bool Guessed();
    }
}
