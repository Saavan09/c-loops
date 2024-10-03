using System;

class Program 
{
    public static void Main(string[] args)
    {
        //variables
        string playerName = "adventurer";
        string userChoice = "NONE";

        //program start
        Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
        Console.WriteLine("Wait... I don't actually know your name.");
        Console.WriteLine("What is your name?");
        Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

        //user input
        playerName = Console.ReadLine();
        Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

        //more story
        Console.WriteLine("" + "We approach a clearing in the jungle\n" + "There seems to be a trail to the left...\n" + "And a cave entrance to the right.\n");
        Console.WriteLine("Which path do you chose?");
        Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose the cave and go right.");

        //more user input
        playerName = Console.ReadLine();
        Console.WriteLine("\nYou chose: " + userChoice+"\n");
    }
}