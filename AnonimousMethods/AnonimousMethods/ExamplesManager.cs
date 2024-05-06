using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimousMethods
{
    //* Delegate Type Declaration
    delegate void MessageHandler(string message);

    internal class ExamplesManager
    {
        public void Example1() 
        {
            //1
            Console.WriteLine("\n> 1 - Call of existing non-anonimous method:");
            var manager = new MessageManager();
            var handler = new MessageHandler(manager.DisplaySomeMessage);
            handler.Invoke("I'm basic delegate");
        }

        public void Example2()
        {
            Console.WriteLine("\n> 2 - Creation and call of anonimous method:");
            MessageHandler handler = delegate(string message) {
                Console.WriteLine($"\n> Anonimous Message:\n {message}"); 
            };
            handler.Invoke("I'm anonymous delegate");
        }
    }
}
