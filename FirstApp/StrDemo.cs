//  Examples

using System;

class StrDemo
{
    static void Main17()
    {
        Console.WriteLine("Первая строка\nВторая строка\nТретья строка");
        Console.WriteLine("Один\tДва\tТри");
        Console.WriteLine("Четыре\tПять\tШесть");

        Console.WriteLine("\"Зачем?\", спросил он.");

        Console.WriteLine(@"Это буквальный 
строковый литерал,
занимающий несколько строк
");
        Console.WriteLine(@"А это вывод с табуляцией:
1 2 3   4
5 6 7   8
");
        Console.WriteLine(@"Отзыв программиста: ""Мне нравиться С#.""");
    }
}