﻿using HangMan.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models.ScaffoldComponents
{
    public class ScaffoldWithRightArm : IScaffoldDisplay
    {
        public string Value { get; }

        public ScaffoldWithRightArm()
        {
            // Strange offset is required so it is displayed properly
            Value = @"                          __________________________ 
                          |                        |                                      
                          |                        |
                          |                       ---
                          |                      |   |
                          |                      |___|
                          |                        |                   
                          |                    ____|____
                          |                        |
                          |                        | 
                          |
                          |
                         /|\
                        / | \
                       /  |  \
                      /___|___\ ";
        }
    }
}
