using System;

namespace Exemplo1
{
    /*
      Prove uma interface unica para varias interfaces. Facade define uma interface de 
      alto nivel que faz com que os subsistemas sejam faceis de utilizar

      Quando usar:
       - voce quer prover uma simples interface para um subsistema complexo.
            Subsistemas geralmente mais complexos evoluem, e muitas classes pequenas são
            criadas, tornando o sistema dificil de ser utilizada
       - existem muitas dependencias entre cliente e implementações de abstração.
       - voce quer criar camadas no seu subsistema. Facade ira definir uma entrada para cada
            nivel do subsistema.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Mortgage mortgage = new Mortgage();
            string name = "Caio";

            bool elegible = mortgage.IsElegible(name, 1000);

            Console.WriteLine(string.Format("Customer {0}, elegible: {1}", name, elegible));

            Console.ReadKey();
        }
    }
}
