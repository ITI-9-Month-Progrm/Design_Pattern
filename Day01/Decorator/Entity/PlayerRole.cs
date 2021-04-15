using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entity
{
    //Decorator
    public class PlayerRole : Player
    {
        Player player1;
        public virtual void passBall()
        {
            if (player1 != null)
                player1.passBall();
        }
        public void AssignPlayer(Player player)
        {
            player1 = player;
        }
     }
}
