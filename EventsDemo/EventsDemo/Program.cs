using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creation and binding of event handler
            /* bankAccount.AmountChanged += signalMess => Console.WriteLine(signalMess);
             Console.WriteLine("\n Transactions Example with Notifications");

             //Demo
             bankAccount.Take(7000);
             DisplayAmount(bankAccount);
             bankAccount.Take(5000);
             DisplayAmount(bankAccount);
             bankAccount.Put(9000);
             DisplayAmount(bankAccount);
             bankAccount.Take(5000);
             DisplayAmount(bankAccount);*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void DisplayAmount(BankAccount bankAccount) => 
            Console.WriteLine($" Current funds: {bankAccount.Amount} uah");
    }
}
