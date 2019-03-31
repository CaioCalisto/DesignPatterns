using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Classes
{
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveState()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.State;
        }

    }
}
