using System;
using System.Collections.Generic;

namespace Challenge_Guess_The_Number
{
    class Program
    {
        //-- This is declaring a function --//
        public static int Process()
        {

        //-- Declaring variables --//
        int number = 0;
        int counter = 7;
        int counter1 = 0;

        //--Generating a random number between 1 to 25 --//
        Random random = new Random();
        int ran = random.Next(1, 25);

        //-- Creating a integer list --//
        List<int> list = new List<int>();

        // While Loop conatining other loops for various outcomes //
        while (number != ran) {

            Console.Write("Enter a Guess: ");
            
        // This converts and stores the input in a variable
            number = Convert.ToInt32(Console.ReadLine());

        // Adds the 'number' entered by user to the List //
            list.Add(number);

        // If statement outcome: If the user guesses correctly //
        if (number == ran) {
            counter--;
            counter1++;
            System.Console.WriteLine("Damn. You Win!");
            System.Console.WriteLine("The Number was indeed " + ran);
            System.Console.WriteLine("You guessed the number in " + counter1 + " guesses");
        }

        // If statement add on: If the user's guess is less than random number //
        if (number > ran) {
            counter--;
            counter1++;
            System.Console.WriteLine("Nope, its less than that!");
            System.Console.WriteLine("You have " + counter + " guesses left!");
        }

        // If statement add on: If the user's guess is higher than random number //
        else if (number < ran) {
            counter--;
            counter1++;
            System.Console.WriteLine("Nope, its greater than that!");
            System.Console.WriteLine("You have " + counter + " guesses left!");
        }

        /* If statement outcome: If the user couldn't guess correctly.
        Also if the counter hits 0. Guesses are over. Game Over */
        if (counter == 0)
        {
            System.Console.WriteLine("HAHAHA YOU LOOSE!");
            System.Console.WriteLine("The number was "+ ran + " YOU FOOL.");
            break;
        }
        // Creates the Log //
        }
        foreach(int thing in list)
        {
            Console.Write("{ " + thing + " }");
        }
        return number;
        }



        // This is the Main void //        
        static void Main(string[] args)
        {   
            Console.WriteLine("Hey there! Lets play a little guessing game. ");
            Console.WriteLine("Guess the number between 0 and 25");

            // This outputs whatever 'Process' function computes
            Process();
        
        }
    }
}
