
namespace Exemplo1.Queries
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, double amount)
        {
            if (amount < 100)
                return true;
            else
                return false;
        }

    }
}
