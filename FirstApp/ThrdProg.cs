// This prgm shows using vars

using System;

class Example3
{
    static void Main3()
    {
        int ivar;
        double dvar;

        ivar = 100;

        dvar = 100.0;

        Console.WriteLine("ivar" + ivar);
        Console.WriteLine("dvar" + dvar);

        Console.WriteLine();

        ivar = ivar / 3;
        dvar = dvar / 3.0;

        Console.WriteLine("ivar" + ivar);
        Console.WriteLine("dvar" + dvar);
    }
}