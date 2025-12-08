using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3ClassesStructuresNamespaces.Structures
{
    public static class PersonStructActions
    {
        public static void CopyWith()
        {
            Person tom = new Person { name = "Tom", age = 22 };
            Person bob = tom with { name = "Bob" };
            bob.Print(); 
        }
    }
}
