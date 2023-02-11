using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldRightLeg : IScaffoldComponent
    {
        public string Value {get;}

        public ScaffoldRightLeg()
        {
            Value = @"    \
                           \
            ";
        }
    }
}