using BankServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    public partial class BankAccount
    {
        public void TransferFunds(BankAccount target, Currency amount)
        {
            if (Balance.Amount >= amount.Amount)
            {
                Withdraw(amount);
                target.Deposit(amount);
                Console.WriteLine($"Transferred {amount.Amount} {amount.CurrencyType} to {target.HolderName}");
            }
            else
            {
                Console.WriteLine("Insufficient balance to transfer funds.");
            }
        }
    }
}
