using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    /*
      Defina uma interface para criar um objeto, mas deixe 
      subclasses decidir qual classe instanciar. Factory method 
      permite que uma classe adie a instanciação para subclasses

      Quando usar
        - a classe não pode antecipar a classe objeto que deve ser criada
        - a classe quer subclasses para especificar o objeto que será criado
        - delegação de responsabilidade para um Helper, que localizará a subclasse delegada
    */
    class Program
    {
        static void Main(string[] args)
        {
            Pizzas.Store chicago = new Pizzas.ChicagoStore();
            chicago.OrderPizza("cheese");

            Pizzas.Store ny = new Pizzas.NYStore();
            ny.OrderPizza("pepperoni");

            Console.ReadKey();
        }
    }
}
