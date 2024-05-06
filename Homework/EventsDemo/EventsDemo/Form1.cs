using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsDemo
{
    public partial class Form1 : Form
    {
        BankAccount bankAccount;
        public Form1()
        {
            InitializeComponent();
            bankAccount = new BankAccount(10_000);
            bankAccount.AmountChanged += signalMess => Console.WriteLine(signalMess);
            BalanceLabel.Text = bankAccount.Amount.ToString() + " uah";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                
                res = int.Parse(AmountTextBox.Text);
                if (res < 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter correct amount", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = 0;
            }
            bankAccount.Put(res);
            BalanceLabel.Text = bankAccount.Amount.ToString() + " uah";
            AmountTextBox.Clear();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            int res = 0;
            try
            {
                res = int.Parse(AmountTextBox.Text);
                if (res < 0)
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter correct amount", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = 0;
            }
            if(res > bankAccount.Amount)
            {
                MessageBox.Show("Insufficient Funds", "Warning",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AmountTextBox.Clear();
                AmountTextBox.Focus();
            }
            else
            {
                bankAccount.Take(res);
                BalanceLabel.Text = bankAccount.Amount.ToString() + " uah";
                AmountTextBox.Clear();
            }
        }
    }
}
