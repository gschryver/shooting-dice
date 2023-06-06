using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "YOU CAN'T SEE ME!";

        public override int Roll()
        {
            Console.WriteLine($"{Name} taunts: {Taunt}");
            return base.Roll();
        }
    }
}