using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant ele = new Elephant();
            ele.Eat(10, false);
            ele.Sleep();
            ele.Eat(5, true);
            ele.Sleep();

            Cat meni = new Cat();
            meni.Sleep();
            meni.Eat(3, true);
            meni.Sleep();
        }
    }
}
