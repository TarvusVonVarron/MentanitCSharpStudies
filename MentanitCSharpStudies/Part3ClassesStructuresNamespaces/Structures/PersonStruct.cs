using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3ClassesStructuresNamespaces.Structures
{
    struct Person
    {
        public string name;
        public int age;
        public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
