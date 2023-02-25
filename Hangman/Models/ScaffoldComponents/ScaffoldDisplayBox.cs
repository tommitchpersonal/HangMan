using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldDisplayBox : IScaffoldDisplayBox
    {
        private readonly List<IScaffoldDisplay> _scaffoldComponents = new()
        {
            new EmptyScaffold(),
            new ScaffoldWithBase(),
            new ScaffoldWithPole(),
            new ScaffoldWithArm(),
            new ScaffoldWithRope(),
            new ScaffoldWithHead(),
            new ScaffoldWithBody(),
            new ScaffoldWithLeftArm(),
            new ScaffoldWithRightArm(),
            new ScaffoldWithLeftLeg(),
            new ScaffoldWithRightLeg()
        };

        public IScaffoldDisplay? Select(int componentToGet)
        {
            if (componentToGet < 0 || componentToGet >= _scaffoldComponents.Count)
            {
                return null;
            }

            return _scaffoldComponents[componentToGet];
        }
    }
}
