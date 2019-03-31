using System;

namespace Exemplo_1.Services
{
    public class Service2 : IService
    {
        public string GetName()
        {
            return "SERVICE2";
        }

        public void Execute()
        {
            Console.WriteLine("Executing service number 2");
        }
    }
}
