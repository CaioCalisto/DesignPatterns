using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /*
     Ter certeza de que a classe tem apenas uma instancia, e prover um unico acesso global à ela
     
     Quando usar:
      - deve existir exatamente 1 instancia da classe, e deve ser acessivel de um
        conhecido ponto de acesso
      - quando uma unica instancia deve ser extendivel por subclasses, e clientes devem
        ser capaz de usá-lo extendendo a instancia sem modificar seu código
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Instanciando a classe");
            SingletonClass instance1 = SingletonClass.GetInstance();
            Console.WriteLine("Classe instanciada com sucesso");

            Console.WriteLine("\n\n");

            Console.WriteLine("Instanciando a classe");
            SingletonClass instance2 = SingletonClass.GetInstance();
            Console.WriteLine("Classe instanciada com sucesso");

            Console.ReadKey();
        }
    }
}
