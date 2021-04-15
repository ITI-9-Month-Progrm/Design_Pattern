using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entity
{
    public class FieldPlayer : Player
    {
        public void passBall()
        {
            Console.WriteLine("Player Now is running");
        }
    }
}
