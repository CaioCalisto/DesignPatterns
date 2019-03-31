
namespace Exemplo_1.Components.Condiments
{
    public class Milk : Condiment
    {
        private Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override Size GetSize()
        {
            return beverage.GetSize();
        }

        public override string GetDescripion()
        {
            return beverage.GetDescripion() + ", milk";
        }

        public override double Cost()
        {
            double condimentcost = 0;
            if (GetSize() == Size.Small)
                condimentcost = 0.2;
            else if (GetSize() == Size.Big)
                condimentcost = 0.5;

            return condimentcost + beverage.Cost();
        }
        

    }
}
