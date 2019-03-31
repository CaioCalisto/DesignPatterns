using System;

namespace Exemplo1.Beverage
{
    public abstract class Caffeine
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            AddCondiments();
            PourInCup();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }



    }
}
