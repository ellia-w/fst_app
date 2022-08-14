//  Decimal

using System;

class UseDecimal
{
    static void Main12()
    {
        decimal price, discount, discounted_price;

        //find disc price

        price = 19.95m;
        discount = 0.15m;

        discounted_price = price - (price * discount); ;
        Console.WriteLine("price with discount: $" + discounted_price);
        Console.WriteLine("price with discount: ${0:C}", discounted_price);
    }
}