using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount caAfif = new CheckingAccount("Afif", 400, 111111);
            CheckingAccount caAfifB = new CheckingAccount("Afif", 400, 111111);
            Console.WriteLine(caAfif);
            CheckingAccount c = new CheckingAccount("Labib", 1000, 1000);
            c.Withdraw(1);
            Console.WriteLine(c.ToString());

            SavingsAccount ash = new SavingsAccount("Hola", 500, 155555);
            Console.WriteLine(ash.ToString());
        }
    }
}
