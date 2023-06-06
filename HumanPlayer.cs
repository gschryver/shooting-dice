using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            // Prompt the user for a roll
            // it shouldn't be over 6 or less than 1
            Console.Write($"{Name}'s Roll: ");
            int roll = int.Parse(Console.ReadLine());

            if (roll > 6 || roll < 1)
            {
                Console.WriteLine("Please enter a number between 1 and 6");
                roll = Roll();
            }

            // Return the user's roll
            return roll;
        }

    }
}