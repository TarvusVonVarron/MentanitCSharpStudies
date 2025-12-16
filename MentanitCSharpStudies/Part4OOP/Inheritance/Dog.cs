using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.Inheritance
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine("Woof woof");
        }

        public override void Move()
        {
            Console.WriteLine("Dog moving");
        }
    }
}
