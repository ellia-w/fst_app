// If

using System;

class IfDemo
{
    static void Main5()
    {
        int a, b, c;
        a = 2;
        b = 3;

        if (a < b) Console.WriteLine(a +" less than " + b);

        Console.WriteLine();

        c = a - b;

        Console.WriteLine("c contains " + c);
        if (c >= a) Console.WriteLine("c is positive");
        else Console.WriteLine(" c is negative");

        Console.WriteLine();

        c = b - a;
        Console.WriteLine("c contains " + c);
        if (c >= 0) Console.WriteLine("c is positive");
        else Console.WriteLine("c is negative");


    }
}