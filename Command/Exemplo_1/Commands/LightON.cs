using System;

namespace Exemplo_1.Commands
{
    public class LightON : ICommand
    {
        public bool IsRunning { get; set; }

        public void Execute()
        {
            Console.WriteLine("Ascendendo a luz!");
        }
    }
}
