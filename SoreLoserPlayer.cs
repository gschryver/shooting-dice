using System;

namespace ShootingDice
{
    // TODO: Complete this class

    
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        // A Player that throws an exception when they lose to the other player
        public override void Play(Player other) {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            if (myRoll <= otherRoll) {
            throw new Exception($"{Name} is a sore loser and quits the game!");
            }
            else {
                Console.WriteLine($"{Name} Wins!");
            }
        }
    }
}