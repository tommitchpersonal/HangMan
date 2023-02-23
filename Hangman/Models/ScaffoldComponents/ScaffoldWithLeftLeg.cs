using HangMan.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithLeftLeg : IScaffoldDisplay
    {
        public string Value { get; }

        public ScaffoldWithLeftLeg()
        {
            Value = @"    __________________________ 
                          |                         |                                      
                          |                         |
                          |                        ---
                          |                       |   |
                          |                       |___|
                          |                         |                   
                          |                     ____|____
                          |                         |
                          |                         | 
                          |                        / \
                          |                       /   \
                         /|\
                        / | \
                       /  |  \
                      /___|___\
            ";
        }
    }
}
