using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.Entity
{
    public class InstagramHandler : IHandler
    {
        IHandler handler1;
        public void HandleRequest(Object request)
        {
            if ((request as Video).Link.Contains("instagram"))
            {
                Console.WriteLine("I am Instagram Handler , I can handle this request");
            }
            else
            {
                Console.WriteLine("I am Instagram Handler , Sorry I can't handle this request");
            }

        }

        public void setNextHandler(IHandler handler)
        {
            handler1 = handler;
        }
    }
}

