using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDP.Entity
{
    public static class Usages
    {
    public static void tryCatchBloks()
        {
            try
            {
                string s = null;
                ProcessString(s);
            }
            // Most specific:
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} First exception caught.", e);
            }
            // Least specific:
            catch (Exception e)
            {
                Console.WriteLine("{0} Second exception caught.", e);
            }
        }



        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }

    }
}
