using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithArm : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithArm()
        {
            Value = @"     _________________________
                          |
                          |
                          |
                          |
                          |
                          |
                          |
                          |
                          |
                          |
                          |
                         /|\
                        / | \
                       /  |  \
                      /___|___\ ";
        }
    }
}