using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldBase : IScaffoldComponent
    {
        public string Value { get; }

        public ScaffoldBase()
        {
            Value = @"   /|\
                        / | \
                       /  |  \
                      /___|___\  ";
        }
    }
}
