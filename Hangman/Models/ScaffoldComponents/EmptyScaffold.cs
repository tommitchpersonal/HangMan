using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class EmptyScaffold : IScaffoldDisplay
    {
        public string Value { get; }

        public EmptyScaffold()
        {
            Value = string.Empty;
        }
    }
}
