using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithBody : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithBody()
        {
            Value = @"    __________________________ 
                          |                        |                                      
                          |                        |
                          |                       ---
                          |                      |   |
                          |                      |___|
                          |                        |                   
                          |                        |
                          |                        |
                          |                        | 
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