using HangMan.Interfaces.Builders;
using HangMan.Interfaces.Models;
using HangMan.Models.ScaffoldComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HangMan.Builders
{
    public class ScaffoldComponentArranger : IScaffoldComponentArranger
    {
        public string ArrangeScaffoldComponents(List<IScaffoldDisplay> scaffoldState)
        {
            switch(scaffoldState.Count)
            {
                case 1:
                {
                    return scaffoldState[0].Value;
 
                }
                case 2:
                {
                    return AttachPoleToBase(scaffoldState.First().Value, scaffoldState[1].Value);    
                }
                case 3: 
                {
                    var poleAndBase = AttachPoleToBase(scaffoldState.First().Value, scaffoldState[1].Value);
                    return AttachArmToScaffold(scaffoldState[2].Value, poleAndBase);
                }
                case 4:
                {
                    var poleAndBase = AttachPoleToBase(scaffoldState.First().Value, scaffoldState[1].Value);
                    var armAndPole = AttachArmToScaffold(scaffoldState[2].Value, poleAndBase);
                    return AttachRopeToScaffold(scaffoldState[3].Value, armAndPole);

                }
            }

            return string.Empty;
        }

        private static string AttachPoleToBase(string scaffoldBase, string scaffoldPole)
        {
            var poleAttachedToArm = scaffoldPole + scaffoldBase;
            return poleAttachedToArm;
        }

        private static string AttachArmToScaffold(string scaffoldArm, string scaffold)
        {
            return  $"{scaffoldArm}{scaffold}";
        }

        private static string AttachRopeToScaffold(string rope, string scaffold)
        {
            return $"{scaffold}  {rope}";
        }


    }
}
