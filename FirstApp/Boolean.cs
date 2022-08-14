//  Bool

using System;

class UseBool
{
    static void Main14()
    {
        bool b;
        b = false;

        Console.WriteLine("b is " + b);
        b = true;
        Console.WriteLine("b is " + b);

        if (b) Console.WriteLine("executed.");

        b = false;
        if (b) Console.WriteLine("Not executed");

        Console.WriteLine("10 > 9 is " + (10 > 9));

    }
}