using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine(magicNumber);
            Console.ReadLine();
        }
    }
}