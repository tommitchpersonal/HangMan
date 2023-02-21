using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldBase : IScaffoldComponent
    {
        public string Value { get; }

        public ScaffoldBase()
        {
            // Weird offset is necessary for correct format

            Value = @"             /|\
                        / | \
                       /  |  \
                      /___|___\  ";
        }
    }
}
