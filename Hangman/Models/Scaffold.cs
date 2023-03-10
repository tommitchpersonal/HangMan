using HangMan.Interfaces.Models;
using HangMan.Models.ScaffoldComponents;

namespace HangMan.Models
{
    public class Scaffold : IScaffold
    {
        public Scaffold(IScaffoldDisplayBox scaffoldDisplayBox)
        {
            _wrongGuesses = 0;
            _scaffoldDisplayBox= scaffoldDisplayBox;
            Display = _scaffoldDisplayBox.Select(_wrongGuesses);
        }

        private int _wrongGuesses { get; set; }

        private readonly IScaffoldDisplayBox _scaffoldDisplayBox;

        public IScaffoldDisplay? Display { get; set; }

        public void AddWrongGuess()
        {
            _wrongGuesses ++;
            Display = _scaffoldDisplayBox.Select(_wrongGuesses);
        }

        public bool Completed()
        {
            return Display?.GetType() == typeof(ScaffoldWithLeftLeg);
        }
    }     
}
