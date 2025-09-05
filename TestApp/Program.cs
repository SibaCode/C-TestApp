using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your surname: ");
        string surname = Console.ReadLine();

        Console.WriteLine($"Hello {firstName} {surname}!");
    }
}
