using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
   public  class Animal
    { 
        public virtual void Voice()
        {
            Console.WriteLine("Animal makes a sound ");
        }
    }

    public class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("I make sound as Bow Bow ");
        }
    }
    public class Cat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("I make sound as Mew Mew ");
        }
    }
    public class Goat : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("I make sound as Maii Maii ");
        }
    }
}
