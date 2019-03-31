using System;

namespace Exemplo_1.Commands
{
    public class Open : ICommand
    {
        public bool IsRunning { get; set; }

        public void Execute()
        {
            Console.WriteLine("Abrindo a garagem!");
        }
    }
}
