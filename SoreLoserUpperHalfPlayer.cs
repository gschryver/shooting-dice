using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
       public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if(myRoll <= otherRoll) {
                throw new Exception($"{Name} is a sore loser and storms out of the game!");
            } 
            else {
                Console.WriteLine($"{Name} Wins!");
            }
        }
        public override int Roll()
        {
            // Return a random number between 4 and 6
            return new Random().Next(4, 7);
        }
    }
}