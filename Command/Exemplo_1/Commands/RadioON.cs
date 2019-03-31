using System;

namespace Exemplo_1.Commands
{
    public class RadioON : ICommand
    {
        public bool IsRunning { get; set; }

        public void Execute()
        {
            ON();
            CD();
            Volume();
        }

        private void ON()
        {
            Console.WriteLine("Ligando o radio!");
        }

        private void CD()
        {
            Console.WriteLine("Colocando o CD!");
        }

        private void Volume()
        {
            Console.WriteLine("Aumentando o volume!");
        }

    }
}
