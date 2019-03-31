using System;

namespace Exemplo_1.Commands
{
    public class Close : ICommand
    {
        public bool IsRunning { get; set; }

        public void Execute()
        {
            Console.WriteLine("Fechando a garagem!");
        }
    }
}
