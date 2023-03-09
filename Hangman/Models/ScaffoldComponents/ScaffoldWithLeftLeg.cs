using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithLeftLeg : IScaffoldDisplay
    {
        public string Value { get; }

        public ScaffoldWithLeftLeg()
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
                          |                       / \
                          |                      /   \
                         /|\
                        / | \
                       /  |  \
                      /___|___\
            ";
        }
    }
}
