using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDP.Entity;

namespace ObserverDP.Entity
{
    //Publisher
    public class Football:Ball
    {
        public int Ball_ID { get; set; }
        public Position ball_position;
        public Position Ball_Position
        {
            get { return ball_position; }
            set
            {
                if (value != ball_position)
                {
                    Position Delta = value - ball_position;
                    ball_position = value;
                    
                }
                //Notify Subscribers
                this.Notify();
            }
        }

        // set of subscribers that will notify with update
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Ball: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Ball: Detached an observer.");
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Ball: Notifying observers...");
            foreach (var observeItem in _observers)
            {
                observeItem.Update(this);
            }
        }

        public override string ToString() => $"Ball {Ball_ID} At {Ball_Position}";
        public void changePosition(Position p)
        {
            this.Ball_Position = p;
        }
    }
}
