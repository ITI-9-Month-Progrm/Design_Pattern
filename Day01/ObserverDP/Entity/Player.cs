using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Entity
{
    public class Player:IObserver
    {
        public int Player_ID { get; set; }
        public string Player_Name { get; set; }
        public Position Player_Position { get; set; }
        public string Player_Team { get; set; }
        public override string ToString() => $"Player : {Player_Name} , Team {Player_Team} , Position {Player_Position}";

        public void Update(Ball ball)
        {
            Player_Position += (ball as Football).Ball_Position;

        }
    }
}
