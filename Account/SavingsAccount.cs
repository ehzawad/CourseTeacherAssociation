using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class SavingsAccount : Account
    {
        readonly string accountType = "SavingsAccount";
        static List<UInt32> savingAccountNumberDB = new List<uint>();

        public SavingsAccount(string name, double accBalance, uint accNumber)
        {
            if (accNumber >= 500000 && accNumber <= 999999)
            {
                if (savingAccountNumberDB.Exists(x => accNumber == x))
                {
                    Console.WriteLine("Please enter an unique account number for Savings Account");
                    Console.WriteLine();
                }
                else
                {
                    this.name = name;
                    this.balance = accBalance;
                    this.accountNumber = accNumber;
                    savingAccountNumberDB.Add(accNumber);
                }
            }
            else
            {
                Console.WriteLine("Account number is not in range for Savings Account");
                Console.WriteLine();
            }
        }


        public void InterestRate()
        {
            if (this.balance > 10000)
            {
                this.balance += Balance * .6;
            }
            else
            {
                this.balance += Balance * .3;
            }
        }

        public override string ToString()
        {
            return "AccountType: " + this.accountType + "->" +  "Account Name: " + this.name + " Balance " + this.balance + " Account Number: " + this.accountNumber;
        }


    }
}
