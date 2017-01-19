using System;

class Program
{
    static void Main()
    {
        double digitOne = double.Parse(Console.ReadLine());
        double digitTwo = double.Parse(Console.ReadLine());
        if (digitOne > digitTwo)
        {
            Console.WriteLine(digitOne);
        }
        else
        {
            Console.WriteLine(digitTwo);
        }
    }
}

