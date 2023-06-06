using System;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        // randomly select a taunt from a list to say to the other player
        public string[] Taunts { get; } = {
            "YOU CAN'T SEE ME!",
            "I'M GONNA BE THE VERY BEST!",
            "LMAO, NERD",
            "GIT GUD, NUB",
            "READY TO GET REKT?"
        };
        public override int Roll()
        {
            Console.WriteLine($"{Name} taunts: {Taunts[new Random().Next(Taunts.Length)]}");
            return base.Roll();
        }
    }
}