using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.Entity
{
    public class FacebookHandler : IHandler
    {
        IHandler handler1;
        public void HandleRequest(Object request)
        {
            if ((request as Video).Link.Contains("facebook"))
            {
                Console.WriteLine("I am Facebook Handler , I can handle this request");
            }
            else
            {
                Console.WriteLine("I am Facebook Handler , Sorry I can't handle this request");
            }

        }

        public void setNextHandler(IHandler handler)
        {
            handler1 = handler;
        }
    }
}
