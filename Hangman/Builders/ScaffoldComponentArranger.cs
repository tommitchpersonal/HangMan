using HangMan.Interfaces.Builders;
using HangMan.Interfaces.Models;
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
            }

            return string.Empty;

        }
    }
}
