using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entity
{
    public class Forward:PlayerRole
    {
        public override void passBall()
        {
            base.passBall();
            ShootGoal();
        }
        public void ShootGoal()
        {
            Console.WriteLine("Player Now will shoot a ball for goal");
        }
    }
}
