using HangMan.Interfaces.Models;

namespace HangMan.Interfaces.Factories
{
    public interface IModelFactory
    {
        public ITargetWord CreateTargetWord();
    }
}