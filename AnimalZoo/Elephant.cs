using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Elephant : Animal, ISleepable
    {
        public Elephant() { }

        static bool isEatingDone = false;
        
        public override void Eat(int quantity, bool isHungry)
        {
           if (isHungry)
            {
                Console.WriteLine("The Elephant will eat " + quantity + " tons of grass");
                isEatingDone = true;
            }
        }

        public void Sleep()
        {
            if (isEatingDone)
            {
                Console.WriteLine("Elephant: I am going for Sleeping");
            }
            else
            {
                Console.WriteLine("Elephant: I need to eat first, because I am hungry");
            }
        }
    }
}
