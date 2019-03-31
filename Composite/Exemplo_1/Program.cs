using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_1.Composites;

namespace Exemplo_1
{
    /*
      Compoe objetos em estruturas de arvores para representar uma hierarquia

      Quando usar:
        - voce quer representar uma hierarquia de objetos
        - voce quer que os clientes sejam capazes de ignorar diferencas entre composicao
            de objetos e objetos individuais. Clientes tratarão todos os objetos em uma
            estrutura uniformemente
     */
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("Picture");
            root.Add(new Primitive("Red Line"));
            root.Add(new Primitive("Blue Circle"));
            root.Add(new Primitive("Green Box"));

            Composite comp = new Composite("Two Circles");
            comp.Add(new Primitive("Black Circle"));
            comp.Add(new Primitive("White Circle"));

            root.Add(comp);

            root.Display(1);

            Console.ReadKey();
        }
    }
}
