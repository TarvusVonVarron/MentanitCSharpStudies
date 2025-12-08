using Part3ClassesStructuresNamespaces.Classes;
using System;

namespace Part3ClassesStructuresNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonActions.PrintNewPerson();
            Console.WriteLine();
            PersonActions.PersonConstructors();

            Person person = new Person("Tom", 33);
            (string name, int age) = person;

            Console.WriteLine(name);   
            Console.WriteLine(age);
        }
    }
}