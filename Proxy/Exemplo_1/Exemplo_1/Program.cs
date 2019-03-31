using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /* 
        fornecer um substituto ou espaço reservado 
        para outro objeto para controlar o acesso a ele 
        
     */
    class Program
    {
        static void Main(string[] args)
        {
            ProxyExample.IImage image = new ProxyExample.ProxyImage("Test.jpg");
            image.Display();

            Console.WriteLine("");

            image.Display();

            Console.ReadKey();
        }
    }
}
