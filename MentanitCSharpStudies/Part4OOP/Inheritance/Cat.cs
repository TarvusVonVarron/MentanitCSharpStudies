using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.Inheritance
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }

        public override void Move()
        {
            Console.WriteLine("Cat moving");
        }
    }
}
