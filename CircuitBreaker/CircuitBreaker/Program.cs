using System;

namespace CircuitBreaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Servico servico = new Servico();
            servico.TestandoServico();
            Console.ReadKey();
        }
    }
}
