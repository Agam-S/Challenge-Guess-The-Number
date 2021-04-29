using System;
using System.Collections.Generic;
namespace Challenge_Guess_The_Number
{
    class Program
    {

        public static int Process(int number)
        {
        int counter = 7;
        while (number != 10) {
            List<int> list = new List<int>();
            list.Add(number);
            number = Convert.ToInt32(Console.ReadLine());
        if (number == 10) {
            counter--;
            System.Console.WriteLine("Damn. You Win!");
            System.Console.WriteLine("The Number was indeed 10");
            System.Console.WriteLine("You guessed the number in " + counter + " guesses");
        }

        if (number > 10) {
            counter--;
            System.Console.WriteLine("Nope, its less than that!");
            System.Console.WriteLine("You have " + counter + " guesses left!");
           
        }
        else if (number < 10) {
            counter--;
            System.Console.WriteLine("Nope, its greater than that!");
            System.Console.WriteLine("You have " + counter + " guesses left!");
        }
        if (counter == 0)
        {
            System.Console.WriteLine("HAHAHA YOU LOOSE!");
            System.Console.WriteLine("The number was 10 YOU FOOL.");
        }
        foreach (int num in list)
        {
            list.
        }
        }
        
        return number;
        }
        static void Main(string[] args)
        {
        Console.WriteLine("Hey there! Lets play a little guessing game. ");

        Console.WriteLine("Guess the number between 0 and 25 ");
        Console.Write("Enter a Guess: ");
        int input = Convert.ToInt32(Console.ReadLine());

        
       Console.WriteLine(Process(input));
        
        }
    }
}
