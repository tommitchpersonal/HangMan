using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models.ScaffoldComponents
{
    public static class ComponentToolBox
    {
        private static List<IScaffoldComponent> scaffoldComponents = new List<IScaffoldComponent>()
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
            return scaffoldComponents[componentToGet];
        }
    }
}
