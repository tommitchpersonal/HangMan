using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldPersonArm : IScaffoldComponent
    {
        public string Value {get;}

        public ScaffoldPersonArm()
        {
            Value = @"     ___";
        }
    }
}