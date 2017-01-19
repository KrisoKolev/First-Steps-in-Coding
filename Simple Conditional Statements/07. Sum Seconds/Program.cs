using System;

class Program
{
    static void Main()
    {
        int racer1 = int.Parse(Console.ReadLine());
        int racer2 = int.Parse(Console.ReadLine());
        int racer3 = int.Parse(Console.ReadLine());

        int sumOfRacers = racer1 + racer2 + racer3;
        int minutes = sumOfRacers / 60;
        int seconds = sumOfRacers % 60;
        string secondsAsString = seconds.ToString();
        if (seconds < 10)
        {
            secondsAsString = 0 + secondsAsString;
        }
            Console.WriteLine($"{minutes}:{secondsAsString}");
    }
}

