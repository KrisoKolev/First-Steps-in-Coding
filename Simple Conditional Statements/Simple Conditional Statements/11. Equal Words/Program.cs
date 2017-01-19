using System;

class Program
{
    static void Main()
    {
        string wordOne = Console.ReadLine().ToLower();
        string wordTwo = Console.ReadLine().ToLower();

        if (wordOne == wordTwo)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

