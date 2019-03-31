
namespace Exemplo_1.Components.Condiments
{
    public class Soy : Condiment
    {
        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override Size GetSize()
        {
            return beverage.GetSize();
        }

        public override string GetDescripion()
        {
            return beverage.GetDescripion() + ", soy";
        }

        public override double Cost()
        {
            double condimentcost = 0;
            if (GetSize() == Size.Small)
                condimentcost = 0.45;
            else if (GetSize() == Size.Big)
                condimentcost = 0.8;

            return condimentcost + beverage.Cost();
        }
    }
}
