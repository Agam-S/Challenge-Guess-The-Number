using System;
using System.Collections.Generic;
namespace Challenge_Guess_The_Number
{
    class Program
    {

        public static int Process()
        {
        int number = 0;
        int counter = 7;
        int counter1 = 0;
        
        while (number != 10) {

            Console.Write("Enter a Guess: ");
            number = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(number);


        if (number == 10) {
            counter--;
            counter1++;
            System.Console.WriteLine("Damn. You Win!");
            System.Console.WriteLine("The Number was indeed 10");
            System.Console.WriteLine("You guessed the number in " + counter1 + " guesses");
        }

        if (number > 10) {
            counter--;
            counter1++;
            System.Console.WriteLine("Nope, its less than that!");
            System.Console.WriteLine("You have " + counter + " guesses left!");
           
        }
        else if (number < 10) {
            counter--;
            counter1++;
            System.Console.WriteLine("Nope, its greater than that!");
            System.Console.WriteLine("You have " + counter + " guesses left!");
        }
        if (counter == 0)
        {
            System.Console.WriteLine("HAHAHA YOU LOOSE!");
            System.Console.WriteLine("The number was 10 YOU FOOL.");
            break;
        }
    
        }
       
        return number;
        }




        static void Main(string[] args)
        {
        Console.WriteLine("Hey there! Lets play a little guessing game. ");

        Console.WriteLine("Guess the number between 0 and 25");
        
        Process();
        
        }
    }
}
