using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    public struct Currency
    {
        public decimal Amount { get; }
        public string CurrencyType { get; }
        public Currency(decimal amount, string currencyType)
        {
            Amount = amount;
            CurrencyType = currencyType;
        }
    }
    public partial class BankAccount
    {
        public string AccountNumber { get; set; }
        public string HolderName { get; set; }
        public Currency Balance { get; set; }
        public BankAccount(string accountNumber, string holderName, Currency balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }
        public void Deposit(Currency amount)
        {
            Balance = new Currency(Balance.Amount + amount.Amount, Balance.CurrencyType);
        }
        public void Withdraw(Currency amount)
        {
            if (Balance.Amount >= amount.Amount)
            {
                Balance = new Currency(Balance.Amount - amount.Amount, Balance.CurrencyType);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public void BalanceCheck()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {HolderName}");
            Console.WriteLine($"Balance: {Balance.Amount} {Balance.CurrencyType}");
        }
    }
}
