using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_1.Locators;
using Exemplo_1.Services;

namespace Exemplo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = Locator.GetService("service1");
            service.Execute();
            service = Locator.GetService("service2");
            service.Execute();
            service = Locator.GetService("SERVICE1");
            service.Execute();
            service = Locator.GetService("SERVICE2");
            service.Execute();


            Console.ReadKey();           
        }
    }
}
