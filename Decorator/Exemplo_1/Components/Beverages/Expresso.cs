
namespace Exemplo_1.Components.Beverages
{
    public class Expresso : Beverage
    {
        private Size size;

        public Expresso(Size size)
        {
            this.Description = "Expresso";
            this.size = size;
        }

        public override Size GetSize()
        {
            return size;
        }
         
        public override double Cost()
        {
            return 1.99;
        }
    }
}
