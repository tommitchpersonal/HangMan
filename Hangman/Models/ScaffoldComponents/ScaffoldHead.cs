namespace HangMan.Models.ScaffoldComponents
{
        public class ScaffoldHead : IScaffoldComponent
    {
        public string Value {get;}

        public ScaffoldHead()
        {
            Value = @"   ___
                        |   |
                        |___|
            ";
        }
    }
}