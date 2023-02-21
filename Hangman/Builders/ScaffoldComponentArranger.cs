using HangMan.Interfaces.Builders;
using HangMan.Interfaces.Models;
using HangMan.Models.ScaffoldComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Builders
{
    public class ScaffoldComponentArranger : IScaffoldComponentArranger
    {
        public string ArrangeScaffoldComponents(List<IScaffoldComponent> scaffoldState)
        {
            switch(scaffoldState.Count)
            {
                case 1:
                {
                    return scaffoldState[0].Value;
 
                }
                case 2:
                {
                    return AttachPoleToBase(scaffoldState);    
                }
                case 3: 
                { 
                    return AttachArmToPole(scaffoldState);
                }
            }

            return string.Empty;
        }

        private static string AttachPoleToBase(List<IScaffoldComponent> scaffoldState)
        {
            var scaffoldBase = scaffoldState.First();
            var scaffoldPole = scaffoldState[1];

            return scaffoldPole.Value + scaffoldBase.Value;
        }

        private static string AttachArmToPole(List<IScaffoldComponent> scaffoldState)
        {
            var poleAttachedToBase = AttachPoleToBase(scaffoldState);
            var scaffoldArm = scaffoldState[2];

            return scaffoldArm.Value + poleAttachedToBase;
        }
    }
}
