using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Entity
{
    public struct Position
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int Z { set; get; }

       
        public static Position operator +(Position L, Position R)
        {
            return new Position()
            {
                X = L.X + R.X,
                Y = L.Y + R.Y,
                Z = L.Z + R.Z
            };
        }
        public static Position operator -(Position L, Position R)
        {
            return new Position()
            {
                X = L.X - R.X,
                Y = L.Y - R.Y,
                Z = L.Z - R.Z
            };
        }
        public override string ToString() => $"({X},{Y},{Z})";

        
    }
}
