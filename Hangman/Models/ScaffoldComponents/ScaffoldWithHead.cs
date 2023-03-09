using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithHead : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithHead()
        {
            Value = @"  
                           _________________________ 
                          |                        |                                      
                          |                        |
                          |                       ---
                          |                      |   |
                          |                      |___|
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