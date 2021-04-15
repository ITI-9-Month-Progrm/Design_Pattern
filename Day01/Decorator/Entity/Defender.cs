using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entity
{
    public class Defender:PlayerRole
    {
        public override void passBall()
        {
            base.passBall();
            Defend();
        }
        public void Defend()
        {
            Console.WriteLine("Player Role Now is Defender");
        }
    }
}
