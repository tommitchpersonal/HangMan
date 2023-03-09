using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithRope : IScaffoldDisplay
    {
        public string Value {get;}

        public ScaffoldWithRope()
        {
            Value = @"   

                           _________________________       
                          |                        |
                          |                        |
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