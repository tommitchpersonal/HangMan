using HangMan.Models;
using HangMan.Interfaces.Models;
using HangMan.Interfaces.Factories;

namespace HangMan.Factories
{
    public class ModelFactory : IModelFactory
    {
        public ITargetWord CreateTargetWord()
        {
            return new TargetWord();
        }
    }
}