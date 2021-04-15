using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entity
{
    public class GoalKeeper : Player
    {
        public void passBall()
        {
            Console.WriteLine("Keeper will Pass the ball to Player");
        }
    }
}
