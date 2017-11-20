using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public abstract class Animal
    {
        abstract public void Eat(int quantity, bool isHungry);
    }
}
