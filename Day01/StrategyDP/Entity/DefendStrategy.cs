using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.Entity
{
    public class DefendStrategy : ITeamStrategy
    {
        public void Play()
        {
            Console.WriteLine("Strategy Team changed into Defend");
        }
    }
}
