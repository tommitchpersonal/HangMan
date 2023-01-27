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
                case 0:
                {
                    State.Add(new ScaffoldBase());
                    break;
                }
                case 1:
                {
                    State.Add(new ScaffoldPole());
                    break;
                }
                case 2:
                {
                    State.Add(new ScaffoldArm());
                    break;
                }
                case 3:
                {
                    State.Add(new ScaffoldRope());
                    break;
                }
                case 4:
                {
                    State.Add(new ScaffoldHead());
                    break;
                }
                case 5:
                {
                    State.Add(new ScaffoldPersonArm());
                    break;
                }
                case 6:
                {
                    State.Add(new ScaffoldPersonArm());
                    break;
                }
                case 7:
                {
                    State.Add(new ScaffoldLeftLeg());
                    break;
                }
                case 8:
                {
                    State.Add(new ScaffoldRightLeg());
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
