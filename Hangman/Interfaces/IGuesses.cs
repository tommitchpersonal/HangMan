using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Interfaces
{
    public interface IGuesses
    {
        public void AddIncorrectGuess(char incorrectGuess);
        public void AddCorrectGuess(char correctGuess);
        public string ReturnIncorrectGuessesAsString();
        public bool HasGuessBeenMadeAlready(char guess);
    }
}
