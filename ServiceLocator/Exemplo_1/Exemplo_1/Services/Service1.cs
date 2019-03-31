using System;

namespace Exemplo_1.Services
{
    public class Service1 : IService
    {
        public string GetName()
        {
            return "SERVICE1";
        }

        public void Execute()
        {
            Console.WriteLine("Executing service number 1");
        }
    }
}
