using HangMan.Interfaces.Models;

namespace HangMan.Interfaces.Factories
{
    public interface IModelFactory
    {
        public ITargetWord CreateTargetWord();
        public IScaffold CreateScaffold();
        public IWordProgress CreateWordProgress(ITargetWord targetWord);
    }
}