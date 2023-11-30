using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Animals
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public abstract void Speak();

        internal class Dog : Animals 
        {
           public override void Speak()
            {
                Console.WriteLine($"{Name} is barking and is {Age} years old");
            }
        }

        internal class Cat : Animals
        {
            public override void Speak()
            {
                Console.WriteLine($"{Name} is meowing and is {Age} years old");
            }
        }
        internal class Cow : Animals
        {
            public override void Speak()
            {
                Console.WriteLine($"{Name} is mooing and is {Age} years old");
            }
        }
        internal class Leon : Animals
        {
            public override void Speak()
            {
                Console.WriteLine($"{Name} is roaring and is {Age} years old");
            }
        }
    }
}
