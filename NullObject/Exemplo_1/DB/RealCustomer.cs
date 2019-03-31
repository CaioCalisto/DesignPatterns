
namespace Exemplo_1.DB
{
    public class RealCustomer : Customer
    {
        public RealCustomer(string name)
        {
            Name = name;
        }

        public override string GetName()
        {
            return Name;
        }

        public override bool Isnull()
        {
            return false;            
        }

    }
}
