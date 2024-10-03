using System;

class Program 
{
    public static void Main(string[] args)
    {
        //variables
        string playerName = "adventurer";

        //program start
        Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
        Console.WriteLine("Wait... I don't actually know your name.");
        Console.WriteLine("What is your name?");
        Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

        //user input
        playerName = Console.ReadLine();
        Console.WriteLine("\nWelcome to the jungle " + playerName + "!");
    }
}