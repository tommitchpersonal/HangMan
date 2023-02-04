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

        public void AddComponent()
        {
            State.Add(ComponentToolBox.GetScaffoldComponent(State.Count));
        }

        public void Display()
        {
            switch (State.Count) 
            {
                case 1:
                {
                    Console.WriteLine(State[0].Value);
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }     
}
