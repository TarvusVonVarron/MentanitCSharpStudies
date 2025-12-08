using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3ClassesStructuresNamespaces.Classes
{
    public static class PersonActions
    {
        public static void PrintNewPerson()
        {
            Person tom = new Person();

            string personName = tom.name;
            int personAge = tom.age;
            Console.WriteLine($"Имя: {personName}  Возраст {personAge}");

            tom.name = "Tom";
            tom.age = 37;

            tom.Print();
        }

        public static void PersonConstructors() 
        {
            Person tom = new();
            Person bob = new("Bob");
            Person sam = new("Sam", 25);

            tom.Print();          
            bob.Print();          
            sam.Print();
        }
    }
}
