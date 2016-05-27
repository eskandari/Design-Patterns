using Facade;
using System;
class CreditUnion
{
    public bool IsBadCredit(Customer c)
    {
        Console.WriteLine("Check bank for " + c.Name);
        return true;
    }

    public bool HasGoodCredit(Customer c)
    {
        Console.WriteLine("Check credit for " + c.Name);
        return true;
    }
}