using System;

namespace Exemplo_1.Commands
{
    public class LightOFF : ICommand
    {
        public bool IsRunning { get; set; }

        public void Execute()
        {
            Console.WriteLine("Apagando a luz!");
        }
        
    }
}
