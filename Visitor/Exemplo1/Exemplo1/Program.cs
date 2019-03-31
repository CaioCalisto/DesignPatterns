using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    /*
        Representar uma operação para ser rodada nos elementos de uma
        estrutura de objetos. Visitor deixa voce definir uma nova operação
        sem mudar as classes dos elementos que ela opera

        Quando usar:
        - uma estrutura de objeto contem muitas classes de objetos 
            com diferentes interfaces, e voce quer rodar operações nestes
            objetos que dependem de suas classes concretas
        - muitas operações distintas e não relacionadas precisam rodar
            em uma estrutura de objeto, e voce quer evitar poluir essas
            classes com essas operações. Visitor deixa voce manter
            operações relacionadas juntas definindo elas em uma classe.
        - classe que define a estrutura raramente muda, mas voce frequentemente
            quer definir uma nova operação na estrutura.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Parts.IComputerParts part = new Parts.Monitor();
            part.Accept(new ComputerDisplayVisitor()); // Accept and Visit
            part.Execute();

            Console.WriteLine("\n\n");

            Parts.IComputerParts part2 = new Parts.Computer();
            part2.Accept(new ComputerDisplayVisitor()); // Accept and Visit
            part2.Execute();

            Console.ReadKey();
        }
    }
}
