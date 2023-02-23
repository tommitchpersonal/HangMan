using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithPole : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithPole()
        {
            Value =
           @"            
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
                      /___|___\ 
            ";
        }
    }
}