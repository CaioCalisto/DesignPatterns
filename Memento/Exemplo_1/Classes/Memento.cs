﻿
namespace Exemplo_1.Classes
{
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }

    }
}
