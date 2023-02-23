using HangMan.Interfaces.Builders;
using HangMan.Interfaces.Models;
using HangMan.Models.ScaffoldComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models
{
    public class Scaffold : IScaffold
    {
        public Scaffold(IScaffoldDisplayBox scaffoldDisplayBox)
        {
            _wrongGuesses = 0;
            _scaffoldDisplayBox= scaffoldDisplayBox;
            ScaffoldDisplay = null;

        }

        private int _wrongGuesses { get; set; }

        private readonly IScaffoldDisplayBox _scaffoldDisplayBox;

        public IScaffoldDisplay? ScaffoldDisplay { get; set; }

        public void AddWrongGuess()
        {
            _wrongGuesses ++;
            ScaffoldDisplay = _scaffoldDisplayBox.Select(_wrongGuesses);
        }
    }     
}
