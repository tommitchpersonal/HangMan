using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithBody : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithBody()
        {
            // Strange offset is required so it is displayed properly
            Value = @"                          __________________________ 
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