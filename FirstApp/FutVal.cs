//  Fut Val

using System;

class FutVal
{
    static void Main13()
    {
        decimal amount, rate_of_return;
        int years, i;

        amount = 1000.0m;
        rate_of_return = 0.07m;
        years = 10;

        Console.WriteLine("Start capital: $" + amount);
        Console.WriteLine("Norms of benefits: " + rate_of_return);
        Console.WriteLine("In " + years + "years");

        for (i = 0; i < years; i++)
        {
            amount = amount + (amount * rate_of_return);
        }
        Console.WriteLine("Future price is $" + amount);
    }
}