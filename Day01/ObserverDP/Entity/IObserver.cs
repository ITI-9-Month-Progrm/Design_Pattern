using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP.Entity
{
    public interface IObserver
    {
        void Update(Ball ball);
    }
}
