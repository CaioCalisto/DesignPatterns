using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /*
       Prove uma maneira de acessar elementos de um objeto agregado sequencialmente
       sem expor sua representação

       Usar quando:
        - para acessar conteudo de objeto agregado sem expor representação interna
        - para suportar mutiplos traversos de objeto agregado
        - prove interface uniforme para estrutura de traversos agregados diferentes
     */
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant.IMenu dinner = new Restaurant.DinnerHouse.Menu();
            Restaurant.IMenu pancake = new Restaurant.PancakeHouse.Menu();

            var menus = new Restaurant.IMenu[2] { dinner, pancake };
            Waitress waitress = new Waitress(menus);
            waitress.PrintMenu();

            Console.ReadKey();
        }
    }
}
