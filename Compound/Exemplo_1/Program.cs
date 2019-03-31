using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ducks.IDuck mallard = new Ducks.Counter(new Ducks.Mallard());
            Ducks.IDuck redhead = new Ducks.Counter(new Ducks.RedHead());
            Ducks.IDuck rubber = new Ducks.Counter(new Ducks.Rubber());
            Ducks.IDuck goose = new Ducks.Counter(new Wilds.DuckAdapter(new Wilds.Goose()));

            Simulate(mallard);
            Simulate(redhead);
            Simulate(rubber);
            Simulate(goose);
            Console.WriteLine("Quantidade de QUACK: " + Ducks.Counter.GetCounter()); // 4 Quacks

            //////////////////////////////////////////////////////////////

            Ducks.DuckFactory factory = new Ducks.Factory();
            Ducks.DuckFactory factorycount = new Ducks.CountQuackFactory();

            Ducks.IDuck mallard2 = factory.CreateMallard();
            Ducks.IDuck redhead2 = factorycount.CreateRedHead();
            Ducks.IDuck rubber2 = factory.CreateRubber();

            Simulate(mallard2);
            Simulate(redhead2);
            Simulate(rubber2);

            Console.WriteLine("Quantidade de QUACK: " + Ducks.Counter.GetCounter()); // 4 + 1 Quack



            Console.ReadKey();
        }

        static void Simulate(Ducks.IDuck duck)
        {
            duck.Quack();
        }

    }
}
