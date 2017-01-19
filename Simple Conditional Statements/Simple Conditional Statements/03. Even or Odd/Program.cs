using System;

class Program
{
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        if (digit % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}
