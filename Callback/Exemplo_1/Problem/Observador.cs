using System;

namespace Exemplo_1.Problem
{
    public class Observador
    {
        public void ExecutarTarefa(string msg)
        {
            Console.WriteLine("Executando Tarefa do Observador: " + msg);
        }


    }
}
