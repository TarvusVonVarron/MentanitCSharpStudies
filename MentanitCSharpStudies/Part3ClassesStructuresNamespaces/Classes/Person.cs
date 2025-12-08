using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3ClassesStructuresNamespaces.Classes
{
    public class Person
    {
        public string name = "Undefined";
        public int age;

        public Person() : this("Неизвестно")
        { }
        public Person(string name) : this(name, 18)
        { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");

        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        }
    }
}
