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
            Console.Write($"{Name}'s Roll: ");
            int roll = int.Parse(Console.ReadLine());

            // Return the user's roll
            return roll;
        }

    }
}