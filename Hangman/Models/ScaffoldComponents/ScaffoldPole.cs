using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldPole : IScaffoldComponent
    {
        public string Value {get;}

        public ScaffoldPole()
        {
            Value = @"   |
                         |
                         |
                         |
                         |
                         |
                         |
                         |
                         |
                         |
                         |
            ";
        }
    }
}