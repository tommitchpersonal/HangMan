using HangMan.Interfaces.Builders;
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
        public Scaffold(IScaffoldComponentArranger scaffoldBuilder)
        {
            State = new List<IScaffoldComponent>();
            _scaffoldBuilder= scaffoldBuilder;
        }

        public List<IScaffoldComponent> State { get; set; }

        private readonly IScaffoldComponentArranger _scaffoldBuilder;

        public void AddComponent()
        {
            State.Add(ComponentToolBox.GetScaffoldComponent(State.Count));
        }

        public void Display()
        {
            var displayedScaffold = _scaffoldBuilder.ArrangeScaffoldComponents(State);
            Console.WriteLine(displayedScaffold);
        }
    }     
}
