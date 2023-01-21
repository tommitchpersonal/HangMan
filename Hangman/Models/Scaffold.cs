using HangMan.Interfaces.Models;
using HangMan.Models.ScaffoldComponents;
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
            State = new List<IScaffoldComponent>();
        }

        public List<IScaffoldComponent> State { get; set; }

        public void Display()
        {

        }
        public void AddComponent()
        {
            switch(State.Count)
            {
                // cannot use string.Empty as case statements don't accept evaluated expressions :(
                case 0:
                {
                    State.Add(new ScaffoldBase());
                    break;
                }
                default:
                {
                    break;
                }
            }
        } 
    }

    public class State
    {

    }
     
}
