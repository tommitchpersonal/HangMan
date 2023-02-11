using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldBody : IScaffoldComponent
    {
        public string Value {get;}

        public ScaffoldBody()
        {
            Value = @"   |
                         |
                         |
            ";
        }
    }
}