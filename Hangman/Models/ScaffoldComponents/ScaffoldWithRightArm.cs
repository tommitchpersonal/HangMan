using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithRightArm : IScaffoldDisplay
    {
        public string Value { get; }

        public ScaffoldWithRightArm()
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
                          |
                          |
                         /|\
                        / | \
                       /  |  \
                      /___|___\ ";
        }
    }
}
