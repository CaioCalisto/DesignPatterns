 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_1.Classes;

namespace Exemplo_1
{
    class Program
    {
        /*
           Sem violar encapsulamento, captura e externaliza um 
           estado de objeto interno e entao este objeto pode ser restaurado
           para um estado anterior

            Quando usar:
             - um Snapshot de um objeto deve ser salvo para ser restaurado depois
             - uma interface direta para obter um estado iria expor detalhes
                da implementação e quebrar o encapsulamento
         */
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            CareTaker caretaker = new CareTaker();

            originator.State = "#1";
            originator.State = "#2";
            caretaker.AddMement(originator.SaveState());

            originator.State = "#3";
            caretaker.AddMement(originator.SaveState());

            originator.State = "#4";
            Console.WriteLine("Actual State: " + originator.State);

            originator.GetStateFromMemento(caretaker.Get(1));
            Console.WriteLine("Actual State: " + originator.State);

            originator.GetStateFromMemento(caretaker.Get(0));
            Console.WriteLine("Actual State: " + originator.State);

            Console.ReadKey();
        }
    }
}
