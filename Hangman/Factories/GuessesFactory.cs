using HangMan.Interfaces;
using HangMan.Interfaces.Factories;

namespace HangMan.Factories
{
    public class GuessesFactory : IGuessesFactory
    {
        public IGuesses CreateGuesses() 
        {
            return new Guesses();
        }
    }
}
