using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithLeftArm : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithLeftArm()
        {
            // Strange offset is required so it is displayed properly
            Value = @"                          __________________________ 
                          |                        |                                      
                          |                        |
                          |                       ---
                          |                      |   |
                          |                      |___|
                          |                        |                   
                          |                    ____|
                          |                        |
                          |                        | 
                          |
                          |
                         /|\
                        / | \
                       /  |  \
                      /___|___\ ";
        }
    }
}