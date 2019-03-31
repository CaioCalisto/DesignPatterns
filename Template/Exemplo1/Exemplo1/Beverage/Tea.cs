using System;

namespace Exemplo1.Beverage
{
    public class Tea : Caffeine
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemmon");
        }

    }
}
