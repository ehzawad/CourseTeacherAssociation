using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public interface IAccount
    {
        string Name { get; }
        double Balance { get; }
        uint AccountNumber { get; }

        double CheckAccountBalance();
        void AddMoney(double balance);
        void Withdraw(double balance);

    }
}
