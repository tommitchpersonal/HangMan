using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithBase : IScaffoldDisplay
    {
        public string Value { get; }

        public ScaffoldWithBase()
        {
            // Weird offset is necessary for correct format

            Value = @"             
                         /|\
                        / | \
                       /  |  \
                      /___|___\  ";
        }
    }
}
