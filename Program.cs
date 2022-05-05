using System;
using System.Xml;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameActive = true;
            while (gameActive)
            {
                Random randomNumber = new Random();

                //Game Title
                Console.WriteLine("********************");
                Console.WriteLine("* Guess The Number *");
                Console.WriteLine("********************\n");
            
                //Ask user for number range
                Console.WriteLine("Please define the number range!");
                Console.Write("Max Range-->");
                int max_Range = Convert.ToInt32(Console.ReadLine());
                Console.Write("Min Range-->");
                int min_Range = Convert.ToInt32(Console.ReadLine());
            
                //Functionality to generate a random Number between max and min Ranges
                int magicNumber = randomNumber.Next(min_Range, max_Range);

                //Asking the user for the guesses
                for (int i = 1; i < 10; i++)
                {
                    Console.Write("Your {0} guess: ",i);
                    int guess = Convert.ToInt32(Console.ReadLine());
                
                    //statement to check the difference
                    if (guess == magicNumber)
                    {
                        Console.WriteLine("You win, your guess was right\n");
                        break;
                    }else if (guess < magicNumber)
                    {
                        Console.WriteLine("The Magic Number is higher than your guess !!\n");
                    }else if (guess > magicNumber)
                    {
                        Console.WriteLine("The Magic Number is lower than your guess !!\n");
                    }
                    else break;
                
                }

                Console.Write("Another Game yes or no: ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.Clear();
                    gameActive = true;
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
            
        }
    }
}