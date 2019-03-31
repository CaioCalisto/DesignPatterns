using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    public delegate void Notificacao(string msg);

    class Program
    {
        static void Main(string[] args)
        {
            Problem.Principal principal = new Problem.Principal();
            Problem.Observador observador = new Problem.Observador();

            principal.EventoNotificacao += new Notificacao(observador.ExecutarTarefa);

            int index = 44;

            principal.ExecutarTarefa(index);

            Console.ReadKey();
        }
    }
}
