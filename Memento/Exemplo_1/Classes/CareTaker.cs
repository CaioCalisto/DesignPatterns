using System.Collections.Generic;

namespace Exemplo_1.Classes
{
    public class CareTaker
    {
        private List<Memento> mementos;

        public CareTaker()
        {
            mementos = new List<Memento>();
        }

        public void AddMement(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento Get(int index)
        {
            return mementos[index];
        }

    }
}
