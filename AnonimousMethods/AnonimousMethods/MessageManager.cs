using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimousMethods
{
    internal class MessageManager
    {
        public void DisplaySomeMessage(string message)
        {
            Console.WriteLine($"\n> Message:\n {message}");
        }
    }
}
