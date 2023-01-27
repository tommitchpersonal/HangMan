namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldArm : IScaffoldComponent
    {
        public string Value {get;}

        public ScaffoldArm()
        {
            Value = @"     _________________________";
        }
    }
}