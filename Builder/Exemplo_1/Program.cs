using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /*
      Separe a construção de um objeto complexo de sua 
      representação para que o mesmo processo de construção 
      possa criar diferentes representações

      Quando usar
      - o algoritmo de criar o objeto complexo deve ser independente das 
        partes que compõe o objeto e como ele será formado
      - o processo de construção deve permitir diferentes representações
        para o objeto que será construido
    */
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            Meal meal = builder.Prepare1();

            meal.ShowItems();
            Console.WriteLine("Total : R$ " + meal.GetCost());
            Console.ReadKey();
        }
    }
}
