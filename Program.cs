using System;

namespace Dice_Roll_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Configurations
            Console.Title = "Dice Roll";
            //Variables
            int roll = 0;
            Random numberGen = new Random();
            //Start
            Console.WriteLine("Press enter to roll a number: ");
            //For loop (helps with the die rolling).
            for(int i = 0; i < 1000; i++)
            {
                //Checks if a key is pressed
                Console.ReadKey();
                //Sets the die roll to a random number between 1 - 6
                roll = numberGen.Next(1, 7);
                //Writes the number of the die
                Console.WriteLine("You Rolled: " + roll);
            }
            //After all die data is typed (in this case you can roll the die 1000 times), once you press a key it closes the console.
            Console.ReadKey();
        }
    }
}
