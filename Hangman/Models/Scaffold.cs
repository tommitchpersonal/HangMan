using HangMan.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Models
{
    public class Scaffold : IScaffold
    {
        public Scaffold()
        {
            State = string.Empty;
        }

        public string State { get; set; }

        public void Display()
        {

        }
        public void AddComponent()
        {
            switch(State)
            {
                // cannot use string.Empty as case statements don't accept evaluated expressions :(
                case "":
                {
                    State = BASE;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }

        private const string BASE = @"    /|\
                                         / | \
                                        /  |  \
                                       /___|___\  ";
    }
}
