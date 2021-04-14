using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Entity
{
    public class Refree:IObserver
    {
        public int Refree_Id {get;set;}
        public string Refree_Name { get; set; }
        public Position Refree_Position { get; set; }
        public override string ToString() => $"Refree : {Refree_Name} ,  Position {Refree_Position}";

        public void Update(Ball ball)
        {
            Refree_Position += (ball as Football).Ball_Position;

        }
    }
}
