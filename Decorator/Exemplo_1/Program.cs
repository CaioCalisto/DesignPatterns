using System;

namespace Exemplo_1
{
    /*
     Anexa responsabilidades adicionais para o objeto dinamicamente. Prove alternativas
     flexiveis para extender funcionalidades

    Quando usar:
        - Para adicionar responsabilidade para objetos individuais dinamicamente e 
            transparentemente, sem afetar outros objetos
        - para responsabilidades que podem ser retirados
        - quando extender uma subclasse não for possivel. Algumas vezes extender subclasses
            irá gerar MUITAS subclasses para todas as combinacoes, entao nesse caso usamos
            DECORATOR
     */
    class Program
    {
        static void Main(string[] args)
        {
            Components.Beverage chocolatewithmilkbig = new Components.Beverages.Chocolate(Components.Size.Big);
            chocolatewithmilkbig = new Components.Condiments.Milk(chocolatewithmilkbig);
            Console.WriteLine(string.Format("{0} {1} - R$ {2}", chocolatewithmilkbig.GetDescripion(), chocolatewithmilkbig.GetSize(), chocolatewithmilkbig.Cost()));

            Console.WriteLine();

            Components.Beverage chocolatewithmilkbig2 = new Components.Beverages.Chocolate(Components.Size.Big);
            chocolatewithmilkbig2 = new Components.Condiments.Milk(chocolatewithmilkbig2);
            chocolatewithmilkbig2 = new Components.Condiments.Soy(chocolatewithmilkbig2);
            Console.WriteLine(string.Format("{0} {1} - R$ {2}", chocolatewithmilkbig2.GetDescripion(), chocolatewithmilkbig2.GetSize(), chocolatewithmilkbig2.Cost()));
             
            Console.ReadKey();
        }
    }
}
