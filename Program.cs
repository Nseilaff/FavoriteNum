using System;

namespace FavoriteNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNum = r.Next(0, 100);
            int userInput = 0;
            while (userInput != favNum)
            {


                Console.WriteLine("Enter a number between 0 - 100");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNum)
                {
                    Console.WriteLine("You are too Low");
                }
                if (userInput >= 101)
                {
                    Console.WriteLine("That is not a valid entry");
                }
                if (userInput > favNum)
                {
                    Console.WriteLine("You are to high");
                }
                if (userInput == favNum)
                {
                    Console.WriteLine("Congratutions you win!");
                }

            }

        }
    }
}

