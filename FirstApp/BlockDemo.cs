//  BlockDemo

using System;

class BlockDemo
{
    static void Main7()
    {
        int i, j , d;

        i = 5;
        j = 10;

        if(i != 0)
        {
            Console.WriteLine("i not a zero");
            d = j / i;
            Console.WriteLine("j/i = " + d);
            //Console.WriteLine(j/i);    
        }
        int prod = 1;
        int sum = 0;
        //int i;

        for (i = 1; i <= 10; i++)
        {
            sum = sum + i;
            prod = prod * i;
            Console.WriteLine(sum);
            Console.WriteLine(prod);
            Console.WriteLine();
        }
        Console.WriteLine("sum is " + sum);
        Console.WriteLine("Multipl " + prod);


    }
}