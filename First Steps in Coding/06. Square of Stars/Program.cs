using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string top = new string('*', n);
        string whiteSpaces = new string(' ', n - 2);

        Console.WriteLine(top);
        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("*" + whiteSpaces + "*");
        }
        Console.WriteLine(top);
    }
}

