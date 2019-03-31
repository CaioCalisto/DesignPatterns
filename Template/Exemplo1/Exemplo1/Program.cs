using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    /*
      Define um esqueleto de algoritmo em uma operação, 
      diferenciando alguns passos em subclasses. Template Method
      deixa subclasses redefinir certos passos sem alterar a estrutura
      do algoritmo

      Quando usar:
       - implementar uma parte invariante de um algoritmo uma vez e 
            deixar as subclasses implementar o restante
       - quando comportamento comum entre subclasses deveria ser fatorada 
            e localizada em uma classe comum e evitar duplicação de codigo
       - controlar extensões de subclasses
     */
    class Program
    {
        static void Main(string[] args)
        {
            PrepareCaffeine prepare = new PrepareCaffeine(new Beverage.Tea());
            prepare.Prepare();

            Console.ReadKey();
        }
    }
}
