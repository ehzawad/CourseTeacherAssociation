using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Account : IAccount
    {
        protected string name;
        protected double balance;
        protected uint accountNumber;

        public string Name
        {
            get { return this.name; }
        }

        public double Balance
        {
            get { return this.balance; }
        }

        public uint AccountNumber
        {        
            get { return this.accountNumber;  }
        }

        public Account()
        {

        }

        public double CheckAccountBalance()
        {
            return this.balance;
        }

        public void AddMoney(double balance)
        {
            if (balance > 0)
            {
                this.balance = this.balance + balance;
            }

        }

        public void Withdraw(double balance)
        {
            if (balance > 0 && this.balance < balance)
            {
                this.balance = this.balance - balance;
            }

        }



    }
}
