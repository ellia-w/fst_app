//  Inches

using System;

class Inches
{
    static void Main8()
    {
        long inches;
        long miles;

        miles = 93000000; //miles to the sun
        inches = miles * 5280 * 12;

        Console.WriteLine("the distance from earth to the sun is " + inches + "inches");


    }
}