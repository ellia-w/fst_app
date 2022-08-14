//  Trigonom

using System;

class Trigonom
{
    static void Main11()
    {
        double theta;
        for(theta = 0.1; theta <= 1.0; theta = theta + 0.1)
        {
            Console.WriteLine("sin of angle " + theta + " is " + Math.Sin(theta));
            Console.WriteLine("cos of angle " + theta + " is " + Math.Cos(theta));
            Console.WriteLine("tan of angle " + theta + " is " + Math.Tan(theta));
            Console.WriteLine();
        }
    }
}