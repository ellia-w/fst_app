//  Examples formats

using System;
using System.Text;  // без этого не выводит в консоль знак валюты



class Formats
{
    static void Main16()
    {
        Console.OutputEncoding = Encoding.GetEncoding("utf-8"); // без этого не выводит в консоль знак валюты
        int i;

        Console.WriteLine("Number\tSquare\tQube");

        for (i = 1; i < 10; i++)
            Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
        Console.WriteLine("Divide 10/3 gives: {0:#.##}", 10.0 / 3.0);
        Console.WriteLine("{0:###,###.##}", 123456.56);

        decimal balance = 12323.09m;
        Console.WriteLine("Curent Balance is {0:C}", balance);
    }
}