using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1.Problem
{
    public class Principal : Mediator
    {
        public void ExecutarTarefa(int index)
        {
            for (int i = index; i < 100; i++)
            {
                if (i < 60)
                    Console.WriteLine("Executando Tarefa Normal, index: " + i);
                else
                    base.Notificar(string.Format("Executando o deletage, index: " + i));
            }
        }


    }
}
