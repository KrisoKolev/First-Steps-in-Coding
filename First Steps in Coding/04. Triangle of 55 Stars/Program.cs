using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int k = 0; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

