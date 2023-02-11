using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldBase : IScaffoldComponent
    {
        public string Value { get; }

        public ScaffoldBase()
        {
            Value = @"   /|\
                        / | \
                       /  |  \
                      /___|___\  ";
        }
    }
}
