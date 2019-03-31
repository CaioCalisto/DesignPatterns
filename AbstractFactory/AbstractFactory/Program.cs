using System;

namespace AbstractFactory
{
    class Program
    {
        /*
          Este padrão permite a criação de famílias de objetos 
          relacionados ou dependentes por meio de uma única 
          interface e sem que a classe concreta seja especificada
          É o mais apropriado quando o número e os tipos gerais de 
          objetos de produtos permanecem constantes, e há diferenças 
          em produtos específicos famílias

          Quando usar:
            - o sistema deve ser independente de qual produto será criado e representado
            - o sistema deve ser configurado com uma familia de produto multiplo
            - uma família de objetos de produtos relacionados é projetada para ser 
                usada em conjunto e você precisa impor essa restrição
            - voce quer prover uma library de produtos e voce quer revelar apenas suas interfaces

        */
        static void Main(string[] args)
        {
            AbstractFactory shapef = FactoryProducer.GetFactory("shape");

            Shapes.IShape circle = shapef.GetShape("circle");
            circle.Draw();

            Shapes.IShape rectangle = shapef.GetShape("rectangle");
            rectangle.Draw();

            AbstractFactory colorf = FactoryProducer.GetFactory("color");

            Colors.IColor blue = colorf.GetColor("blue");
            blue.Fill();


            Console.ReadKey();
        }
    }
}
