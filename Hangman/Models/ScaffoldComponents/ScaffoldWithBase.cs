using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithBase : IScaffoldDisplay
    {
        public string Value { get; }

        public ScaffoldWithBase()
        {
            Value = @"             
                         /|\
                        / | \
                       /  |  \
                      /___|___\  ";
        }
    }
}
