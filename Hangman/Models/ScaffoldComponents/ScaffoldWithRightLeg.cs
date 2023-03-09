using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithRightLeg : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithRightLeg()
        {
            Value = @"    __________________________ 
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