using Facade;
using System;

namespace Facade
{
    public class Mortgage
    {
        private CreditUnion _credit = new CreditUnion();
        private Bank _bank = new Bank();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", cust.Name, amount);
            bool eligible = true;

            if (!_credit.IsBadCredit(cust))
            {
                eligible = false;
            }
            else if (!_bank.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}