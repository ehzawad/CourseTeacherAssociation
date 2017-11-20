using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Cat : Animal, ISleepable
    {
        public Cat() { }

        static bool isEatingDone = false;
        public override void Eat(int quantity, bool isHungry)
        {
            if (isHungry)
            {
                Console.WriteLine("The Cat will eat " + quantity + " of proteins");
                isEatingDone = true;
            }
        }

        public void Sleep()
        {
            if (isEatingDone)
            {
                Console.WriteLine("Cat: I am going for Sleeping");
            }
            else
            {
                Console.WriteLine("Cat: I need to eat first, because I am hungry");
            }
        }
    }
}
