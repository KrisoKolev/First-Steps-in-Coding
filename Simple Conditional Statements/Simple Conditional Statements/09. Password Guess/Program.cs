using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        if (password == "s3cr3t!P@ssw0rd")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}
