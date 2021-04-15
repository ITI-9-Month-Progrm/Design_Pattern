using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.Entity
{
    public interface IHandler
    {
        //Successor in UML
        void setNextHandler(IHandler handler);
        //in case i don't know type of request
        void HandleRequest(Object request);
    }
}
