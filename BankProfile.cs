using System;
using System.Collections.Generic;
using System.Text;

namespace Array_of_Accounts_Bank_
{
    internal class BankProfile
    {
        private string accountId;
        private string holderName;
        private double balance;
        private string type;
        public string AccountId => accountId;
        public string HolderName => holderName;
        public double Balance => balance;
        public string Type => type;
        public BankProfile(string name, double initialAmount, string accType)
        {
            holderName = name;
            balance = initialAmount;
            type = accType;
            accountId = GenerateAccountNumber();
        }
        private string GenerateAccountNumber()
        {
            Random r = new Random();
            return "IDBI" + r.Next(100000000, 999999999);
        }
        public void AddFunds(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount deposited successfully");
            }
        }
        public void TakeFunds(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal successful.");
            }
            else
            {
                Console.WriteLine("Cannot withdraw. Minimum balance of 500 must be maintained");
            }
        }

    }
}
