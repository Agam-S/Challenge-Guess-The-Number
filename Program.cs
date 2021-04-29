using System;
using System.Collections.Generic;
namespace Challenge_Guess_The_Number
{
    class Program
    {

        public static int Process(int number)
        {
        List<int> num = new List<int>();
        while(number != 10) {
            num.Add(number);
            number =Convert.ToInt32(Console.ReadLine());
        if (number == 10) {
            System.Console.WriteLine("Damn. You Win!");
            System.Console.WriteLine("The Number was indeed 10");
        }

        else if (number !=10) {

        if (number > 10) {
            System.Console.WriteLine("Nope, its less than that!");
        }
        else if (number < 10) {
            System.Console.WriteLine("Nope, its greater than that!");
        }
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

        
       Console.WriteLine(Process(input) );
        
        }
    }
}
