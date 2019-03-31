
namespace Exemplo_1.Components
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";

        public abstract Size GetSize();
        
        public virtual string GetDescripion()
        {
            return Description;
        }

        public abstract double Cost();

        
    }
}
