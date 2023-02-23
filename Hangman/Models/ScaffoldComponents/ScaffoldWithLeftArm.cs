using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithLeftArm : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithLeftArm()
        {
            Value = @"    __________________________ 
                          |                         |                                      
                          |                         |
                          |                        ---
                          |                       |   |
                          |                       |___|
                          |                         |                   
                          |                     ____|
                          |                         |
                          |                         | 
                          |
                          |
                         /|\
                        / | \
                       /  |  \
                      /___|___\ ";
        }
    }
}