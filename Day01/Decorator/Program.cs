using Decorator.Entity;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            FieldPlayer fieldPlayer = new FieldPlayer();
            Forward forward = new Forward();
            MidFielder midfielder = new MidFielder();

            // Link decorators
            forward.AssignPlayer(fieldPlayer);
            midfielder.AssignPlayer(forward);

            midfielder.passBall();
        }
    }
}
