using System;

namespace Exemplo_1.Commands
{
    public class RadioOFF : ICommand
    {
        public bool IsRunning { get; set; }

        public void Execute()
        {
            CD();
            OFF();
        }

        private void CD()
        {
            Console.WriteLine("Removendo o CD!");
        }

        private void OFF()
        {
            Console.WriteLine("Desligando o radio!");
        }

    }
}
