using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithRightLeg : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithRightLeg()
        {
            // Strange offset is required so it is displayed properly
            Value = @"                          __________________________ 
                          |                        |                                      
                          |                        |
                          |                       ---
                          |                      |   |
                          |                      |___|
                          |                        |                   
                          |                    ____|____
                          |                        |
                          |                        | 
                          |                         \
                          |                          \
                         /|\
                        / | \
                       /  |  \
                      /___|___\
            ";
        }
    }
}