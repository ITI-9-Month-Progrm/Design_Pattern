using ObserverDP.Entity;
using System;

namespace ObserverDP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Positions 
            Position playerPosition = new Position();
            playerPosition.X = 5;
            playerPosition.Y = 10;
            playerPosition.Z = 15;
            Position ballPosition = new Position();
            ballPosition.X = 10;
            ballPosition.Y = 20;
            ballPosition.Z = 30;
            Position newBallPosition = new Position();
            newBallPosition.X = 5;
            newBallPosition.Y = 10;
            newBallPosition.Z = 15;
            Position refreePosition = new Position();
            refreePosition.X = 5;
            refreePosition.Y = 15;
            refreePosition.Z = 25;

            //---------------------------------------BALL----------------------

            Football football = new Football();
            football.Ball_Position = ballPosition;
            //-------------------------------------PLAYER-----------------------
            Player player1 = new Player();
            player1.Player_Name = "Abo Trika";
            player1.Player_Team = "Al Ahly";
            player1.Player_Position = playerPosition;

            Console.WriteLine("Before Updating : " + player1.ToString());
            football.Attach(player1);
            football.changePosition(newBallPosition);
            Console.WriteLine("After Updating : " + player1.ToString());
            //------------------------------REFREE---------------------------
            Refree refree1 = new Refree();
            refree1.Refree_Name = "Al7km";
            refree1.Refree_Position = refreePosition;

            Console.WriteLine("Before Updating : " + refree1.ToString());
            football.Attach(refree1);
            football.changePosition(newBallPosition);
            Console.WriteLine("After Updating : " + refree1.ToString());

        }
    }
}
