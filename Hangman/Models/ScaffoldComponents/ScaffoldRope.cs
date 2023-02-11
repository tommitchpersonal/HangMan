using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldRope : IScaffoldComponent
    {
        public string Value {get;}

        public ScaffoldRope()
        {
            Value = @"   |
                         |
            ";
        }
    }
}