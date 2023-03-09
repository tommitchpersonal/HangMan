namespace HangMan.Interfaces.Models
{
    public interface IScaffold
    {
        public IScaffoldDisplay? Display { get; set; }
        public void AddWrongGuess();
        public bool Completed();
    }
}
