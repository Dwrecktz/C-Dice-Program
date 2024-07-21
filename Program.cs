using System;

namespace Dice_Roll_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int roll = 0;

            Random numberGen = new Random();

            Console.WriteLine("Press enter to roll a number: ");

            for(int i = 0; i < 1000; i++)
            {
                Console.ReadKey();
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You Rolled: " + roll);
            }
            Console.ReadKey();
        }
    }
}
