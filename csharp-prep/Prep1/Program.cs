using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user their name.
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");
    }
}