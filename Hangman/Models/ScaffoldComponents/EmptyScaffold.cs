using HangMan.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models.ScaffoldComponents
{
    public class EmptyScaffold : IScaffoldDisplay
    {
        public string Value { get; }

        public EmptyScaffold()
        {
            Value = string.Empty;
        }
    }
}
