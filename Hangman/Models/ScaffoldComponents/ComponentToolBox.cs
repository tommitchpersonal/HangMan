using HangMan.Interfaces.Models;

namespace HangMan.Models.ScaffoldComponents
{
    public static class ComponentToolBox
    {
        private static readonly List<IScaffoldComponent> _scaffoldComponents = new()
        {
            new ScaffoldBase(),
            new ScaffoldPole(),
            new ScaffoldArm(),
            new ScaffoldRope(),
            new ScaffoldHead(),
            new ScaffoldBody(),
            new ScaffoldPersonArm(),
            new ScaffoldPersonArm(),
            new ScaffoldLeftLeg(),
            new ScaffoldRightLeg()
        };

        public static IScaffoldComponent GetScaffoldComponent(int componentToGet)
        {
            return _scaffoldComponents[componentToGet];
        }
    }
}
