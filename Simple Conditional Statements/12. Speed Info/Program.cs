using System;

class Program
{
    static void Main()
    {
        decimal speedInfo = decimal.Parse(Console.ReadLine());

        if (speedInfo <= 10)
        {
            Console.WriteLine("slow");
        }
        else if (speedInfo > 10 && speedInfo <= 50)
        {
            Console.WriteLine("average");
        }
        else if (speedInfo > 50 && speedInfo <= 150)
        {
            Console.WriteLine("fast");
        }
        else if (speedInfo > 150 && speedInfo <= 1000)
        {
            Console.WriteLine("ultra fast");
        }
        else
        {
            Console.WriteLine("extremly fast");
        }
    }
}

