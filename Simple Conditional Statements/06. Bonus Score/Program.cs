using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter score: ");
        int number = int.Parse(Console.ReadLine());
        double bonus = 0;

        if (number <= 100)
        {
            bonus = 5;
        }
        else if (number <= 1000)
        {
            bonus = number * 0.2;
        }
        else
        {
            bonus = number * (10 / 100);
        }
        if (number % 2 == 0)
        {
            bonus += 1;
        }
        else if (number / 10 == 5)
        {
            bonus += 2;
        }
        Console.WriteLine($"Bonus score: {bonus}");
        Console.WriteLine($"Total score: {number + bonus}");
    }
}

