using StrategyDP.Entity;
using System;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamContext teamContext = new TeamContext();
            AttackStrategy attackStrategy = new AttackStrategy();
            DefendStrategy defendStrategy = new DefendStrategy();
            teamContext.setStartegy(attackStrategy);
            teamContext.PlayGame();
            teamContext.setStartegy(defendStrategy);
            teamContext.PlayGame();
        }
    }
}
