using HangMan.Models;
using HangMan.Interfaces.Models;
using HangMan.Interfaces.Factories;
using HangMan.Models.ScaffoldComponents;

namespace HangMan.Factories
{
    public class ModelFactory : IModelFactory
    {
        private readonly IScaffoldDisplayBox _displayBox = new ScaffoldDisplayBox();
        public ITargetWord CreateTargetWord()
        {
            return new TargetWord();
        }

        public IScaffold CreateScaffold() 
        {
            return new Scaffold(_displayBox);
        }

        public IWordProgress CreateWordProgress(ITargetWord targetWord) 
        {
            return new WordProgress(targetWord);
        }
    }
}