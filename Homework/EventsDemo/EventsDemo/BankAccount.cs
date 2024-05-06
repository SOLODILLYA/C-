using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    delegate void AccountEventHandler(string signalMessage);

    internal class BankAccount
    {
        public event AccountEventHandler AmountChanged;
        public int Amount { get; set; }

        public BankAccount(int startSum) => Amount = startSum;

        public void Put(int sum)
        {
            Amount += sum;
            AmountChanged.Invoke($" Account pop up for {sum} uah");
        }

        public void Take(int sum) {
            if (Amount >= sum) {
                Amount -= sum;
                AmountChanged.Invoke($" Account withdrawal for {sum} uah");
            }else
            {
                AmountChanged.Invoke($" Insufficient funds\n Current balance: {Amount} uah");
            }
        }
    }
}
