using System;
using Exemplo1.Queries;

namespace Exemplo1
{
    public class Mortgage
    {
        private Queries.Bank bank;
        private Queries.Credit credit;
        private Queries.Loan loan;

        public Mortgage()
        {
            bank = new Bank();
            credit = new Credit();
            loan = new Loan();
        }

        public bool IsElegible(string name, double amount)
        {
            Console.WriteLine(string.Format("{0} applies for {1} loan", name, amount));
            Customer customer = new Customer(name);

            bool elegible = true;

            if (!bank.HasSufficientSavings(customer, amount))
                elegible = false;
            else if (!credit.HasGoodCredit(customer))
                elegible = false;
            else if (!loan.HasNoBadLoans(customer))
                elegible = false;

            return elegible;
        }


    }
}
