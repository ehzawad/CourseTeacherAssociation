using System;
using System.Collections.Generic;


namespace Account
{
    public class CheckingAccount : Account
    {
        readonly string accountType = "CheckingAccount";
        static List<uint> checkingAccountdatabase = new List<uint>();

        public CheckingAccount(string accountHolderName, double accountBalance, uint accountNumber)
        {
         
          if (accountNumber >= 100000 && accountNumber <= 499999)
          {
              if (checkingAccountdatabase.Exists(x => accountNumber == x))
              {
                  Console.WriteLine("Please Enter a new account number checkingAccount");
              }
              else
              {
                  this.name = accountHolderName;
                  this.balance = accountBalance;
                  this.accountNumber = accountNumber;
                  checkingAccountdatabase.Add(accountNumber);
              }
          }
          else
          {
              Console.WriteLine("Account Number is not in range for Checking Account");

          }
         
        }


        public void OrderCheckbook()
        {
            Console.WriteLine("Order a Checkbook");
        }


        public override string ToString()
        {
            return "AccountType: " + this.accountType + "->" + "Account Name: " + this.name + " Balance " + this.balance + " Account Number: " + this.accountNumber;
        }



    }
}
