using HangMan.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Interfaces.Builders
{
    public interface IScaffoldComponentArranger
    {
        public string ArrangeScaffoldComponents(List<IScaffoldComponent> scaffoldState);
    }
}
