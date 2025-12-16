using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4OOP.Inheritance
{
    internal static class InheritanceWorker
    {
        public static void Run()
        {
            Animal animal = new Dog("Sharik");
            animal.Speak();

            Animal[] animals = new Animal[] { new Cat("Bars"), new Dog("Sharik") };

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].Name);
                AnimalActions(animals[i]);
            }
        }

        private static void AnimalActions(Animal animal)
        {
            animal.Speak();
            animal.Move();
        }
    }
}
