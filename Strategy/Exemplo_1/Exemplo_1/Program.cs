using System;

namespace Exemplo_1
{
    /*
      Define uma familia de algoritmos, encapsulados em um, e faz eles serem
        interselecionavel.
    
      Quando usar:
      - muitas classes relacionadas diferem em seus comportamentos.
      - voce precisa de diferentes algoritmos
      - um algoritmo usa dados que o cliente não deveria saber
      - 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Operations.IOperation add = new Operations.Add();
            Context context = new Context(add);
            context.DoOperation(5, 9);

            Console.ReadKey();
        }
    }
}
