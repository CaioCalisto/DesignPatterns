using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DB.Customer customer1 = CustomerStore.GetCustomer("Rob");
            DB.Customer customer2 = CustomerStore.GetCustomer("Joe");
            DB.Customer customer3 = CustomerStore.GetCustomer("Caio");

            Console.WriteLine(string.Format("{0}\n{1}\n{2}", customer1.GetName(), customer2.GetName(), customer3.GetName()));

            Console.ReadKey();
        }
    }
}
