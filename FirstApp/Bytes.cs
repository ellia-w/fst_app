//  Byte

using System;

class ByteDemo
{
    static void Main9()
    {
        byte x;
        int sum;

        sum = 0;

        for(x = 1; x <= 100; x++)
            sum = sum + x; 
        Console.WriteLine("sum of numbers from 1 till 100 is " + sum);

    }
}