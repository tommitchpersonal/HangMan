using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan.Interfaces.Models
{
    public interface IScaffold
    {
        public string State { get; set; }
        public void Display();
        public void AddComponent();
    }
}
