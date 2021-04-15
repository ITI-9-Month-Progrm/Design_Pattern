using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entity
{
    public class MidFielder:PlayerRole
    {
        public override void passBall()
        {
            base.passBall();
            Dribble();
        }
        public void Dribble()
        {
            Console.WriteLine("Player Role Now is Dribbler");
        }
    }
}
